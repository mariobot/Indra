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
            // Este origen de datos se puede cambiar por un WEB Service por tiempo no lo hice
            List<String> NombresValidos = new List<string>() { "juliana", "pedro", "juan", "lina" };

            _nombre = _nombre.Trim(); // quito los espacios
            _nombre = _nombre.ToLower(); // todo en minusculas

            if (NombresValidos.Contains(_nombre))
                return true;
            else
                return false;
        }

        public static bool Rango(double? min, double? max)
        {
            if (min != null)
                if (max != null)
                {
                    if (min > max)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            else
                return false;
        }

        public static bool FechaEliminacion(DateTime fechaRegistro)
        {
            DateTime fechaActual = DateTime.Now;

            double days = (fechaActual - fechaRegistro).TotalDays;

            if (days >= 30)
                return true;
            else
                return false;
        }
    }
}
