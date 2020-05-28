using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDePonto.Models
{
    public class Usuario
    {
        [key]
        [Display(Name = "Código")]
        public int CodUsuario { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "E-mail")]
        [StringLength(30, ErrorMessage = "O campo {0} é limitado a 30 caracteres.")]
        [EmailAddress(ErrorMessage = "Campo {0} inválido")]
        public string Email { get; set; }
        [StringLength(12, ErrorMessage = "Campo limitado a 12 caracteres")]
        public string Login { get; set; }
        [StringLength(10, ErrorMessage = "campo limitado a 10 caracteres")]        
        public string Senha { get; set; }
        public DateTime DatCadastro { get; set; }
        [Display(Name = "Situação")]
        public bool IndAtivo { get; set; }
    }
}
