using ControleDePonto.Models;
using ControleDePonto.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ControleDePonto.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
     
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;           
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var retorno = _usuarioRepository.ObtemUsuario(usuario.Email, usuario.Senha);

                //se sucesso redireciono
                if (retorno != null && retorno.IndAtivo == true)
                {
                    ViewBag.Codigo = 0;
                    ViewBag.Mensagem = "Autenticação realizada com sucesso!";

                    //HttpContext.Session.SetString("Cd_usuario", JsonConvert.SerializeObject(retorno));
                    
                    return RedirectToAction("Index", "RegistroPonto");
                }
            }

            //erro
            ViewBag.Mensagem = "Dados Inválidos!";
            ViewBag.Codigo = 1;

            return View(usuario);
        }                   
    }
}