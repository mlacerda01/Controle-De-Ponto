using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ControleDePonto.Models;
using ControleDePonto.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;

namespace ControleDePonto.Controllers
{
    public class RegistroPontoController : Controller
    {
        private readonly IRegistroPontoRepository _registroPonto;
        private readonly IConfiguration _configuration;

        public RegistroPontoController(IRegistroPontoRepository registroPonto, IConfiguration configuration)
        {
            _registroPonto = registroPonto;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _registroPonto.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Adicionar(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(RegistroPonto registro)
        {
            if (ModelState.IsValid)
            {
                registro.TotalHoras = (registro.HoraSaidaAlmoco - registro.HoraEntrada) + (registro.HoraSaida - registro.HoraRetornoAlmoco);
                registro.CodUsuario = 1;
                int codRetorno = _registroPonto.Add(registro);

                if (codRetorno == 1)
                    return RedirectToAction("Index", "RegistroPonto");
                else
                    return View(registro);
            }

            return View(registro);
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            if (!id.HasValue)
                return NotFound();

            var registro = _registroPonto.Get(id.Value);

            return View(registro);
        }

        [HttpGet]
        public IActionResult Deletar(int? id)
        {
            if (!id.HasValue)
                return NotFound();

            var registro = _registroPonto.Get(id.Value);

            return PartialView(registro);
        }
        [HttpPost]
        public IActionResult Deletar(RegistroPonto registro)
        {           
            if(registro.CodRegistro == 0)
                return View();
            
            int codRetorno = _registroPonto.Delete(registro.CodRegistro);

            if (codRetorno == 1)
                return RedirectToAction("Index", "RegistroPonto");
            else
                return View(registro);

        }

        [HttpGet]
        public IActionResult Atualizar(int? id)
        {
            if (!id.HasValue)
                return NotFound();

            var registro = _registroPonto.Get(id.Value);
            return View(registro);
        }

        [HttpPost]
        public IActionResult Atualizar(RegistroPonto registro)
        {
            if (registro == null)
                return NotFound();

            registro.TotalHoras = (registro.HoraSaidaAlmoco - registro.HoraEntrada) + (registro.HoraSaida - registro.HoraRetornoAlmoco);
            var aux = (registro.TotalHoras * 24).ToString("");
            var codRetorno = _registroPonto.Edit(registro);

            if (codRetorno == 1)
                return RedirectToAction("Index", "RegistroPonto");
            else
                return BadRequest();
        }

        [HttpGet]
        public FileResult GerarExcel()
        {
            string diretorio = _configuration["filePath"];
            string fileName = String.Format("exportacao{0}{1}", DateTime.Now.ToString("ddMMyyyyHHmm"), ".xlsx");
            int linha = 1;

            List<RegistroPonto> lstRegistroPontos = _registroPonto.GetAll();
            string caminhoArquivo = Path.Combine(diretorio, fileName);
            var fi = new FileInfo(caminhoArquivo);

            if (fi.Exists)
                fi.Delete();

            using (var arquivo = new FileStream(caminhoArquivo, FileMode.CreateNew))
            {
                using (var excel = new ExcelPackage(arquivo))
                {
                    var sheet = excel.Workbook.Worksheets.Add("Registros");

                    // cabeçalho
                    sheet.Cells[linha, 1].Value = "Data";
                    sheet.Cells[linha, 2].Value = "Hora de Entrada";
                    sheet.Cells[linha, 3].Value = "Saída do Almoço";
                    sheet.Cells[linha, 4].Value = "Retorno do Almoço";
                    sheet.Cells[linha, 5].Value = "Hora de Entrada";
                    sheet.Cells[linha, 6].Value = "Total de Horas";

                    foreach (var item in lstRegistroPontos)
                    {
                        linha++;

                        sheet.Cells[linha, 1].Value = item.Date.ToString("dd/MM/yyyy");
                        sheet.Cells[linha, 2].Value = item.HoraEntrada.ToString();
                        sheet.Cells[linha, 3].Value = item.HoraSaidaAlmoco.ToString();
                        sheet.Cells[linha, 4].Value = item.HoraRetornoAlmoco.ToString();
                        sheet.Cells[linha, 5].Value = item.HoraSaida.ToString();
                        sheet.Cells[linha, 6].Value = item.TotalHoras.ToString();

                    }

                    sheet.Row(1).Style.Font.Bold = true;
                    sheet.Column(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Column(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Column(3).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Column(4).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Column(5).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Column(6).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    sheet.Cells.AutoFitColumns();
                    sheet.View.FreezePanes(2, 1);
                    excel.Save();

                    arquivo.Flush();

                }
            }
            
            byte[] bytesArquivo = System.IO.File.ReadAllBytes(caminhoArquivo);
            fi.Delete();

            string tipoArquivo = "application/xlsx";
            return File(bytesArquivo, tipoArquivo, fileName);

        }        
    }
}