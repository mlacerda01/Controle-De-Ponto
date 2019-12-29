using ControleDePonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDePonto.Repository
{
    public interface IRegistroPontoRepository
    {
        int Add(RegistroPonto registro);
        List<RegistroPonto> GetAll();
        RegistroPonto Get(int id);
        int Edit(RegistroPonto registro);
        int Delete(int id);
    }
}
