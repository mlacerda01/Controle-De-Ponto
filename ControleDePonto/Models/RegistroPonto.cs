using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDePonto.Models
{
    public class RegistroPonto
    {
        [Key]
        [Display(Name = "Código")]
        public int CodRegistro { get; set; }
        public int CodUsuario { get; set; }
        [Display(Name = "Data")]
        [Required]
        public DateTime Date { get; set; }
        [Display(Name = "Entrada")]
        public TimeSpan HoraEntrada { get; set; }
        [Display(Name = "Saída Almoço")]
        public TimeSpan HoraSaidaAlmoco { get; set; }
        [Display(Name = "Volta Almoço")]
        public TimeSpan HoraRetornoAlmoco { get; set; }
        [Display(Name = "Saída")]
        public TimeSpan HoraSaida { get; set; }
        [Display(Name = "Total Horas")]
        public TimeSpan TotalHoras { get; set; }
        [Display(Name = "Total Horas Convertidas")]
        public string TotalHorasConvertidas { get; set; }
        [Display(Name = "Descrição")]
        public string DescricaoAtividades { get; set; }
    }
}
