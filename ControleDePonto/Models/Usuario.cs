using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDePonto.Models
{
    public class Usuario
    {
        [key]
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DatCadastro { get; set; }
        public bool IndAtivo { get; set; }
    }
}
