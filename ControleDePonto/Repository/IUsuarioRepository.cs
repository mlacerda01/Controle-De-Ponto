using ControleDePonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDePonto.Repository
{
    public interface IUsuarioRepository
    {
        Usuario ObtemUsuario(string email, string senha);
    }
}