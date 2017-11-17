using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLoyic
{
    public static class ValidarBL
    {
        public static bool Nombre(string _nombre)
        {
            List<String> NombresValidos = new List<string>() { "juliana", "pedro", "juan", "lina" };

            _nombre = _nombre.Trim(); // quito los espacios
            _nombre = _nombre.ToLower(); // todo en minusculas

            if (NombresValidos.Contains(_nombre))
                return true;
            else
                return false;
        }
    }
}
