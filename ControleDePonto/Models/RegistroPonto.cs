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
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public DateTime Date { get; set; }
        [Display(Name = "Entrada")]
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public TimeSpan HoraEntrada { get; set; }
        [Display(Name = "Saída Almoço")]
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public TimeSpan HoraSaidaAlmoco { get; set; }
        [Display(Name = "Volta Almoço")]
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public TimeSpan HoraRetornoAlmoco { get; set; }
        [Display(Name = "Saída")]
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public TimeSpan HoraSaida { get; set; }
        [Display(Name = "Total Horas")]
        public TimeSpan TotalHoras { get; set; }
        [Display(Name = "Total Horas Convertidas")]
        public string TotalHorasConvertidas { get; set; }
        [Display(Name = "Descrição")]
        [StringLength(500, ErrorMessage ="Capacidade máxima do campo {0} é de 500 caracteres")]
        public string DescricaoAtividades { get; set; }
    }
}
