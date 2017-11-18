using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace BussinessLoyic
{
    public static class FiltrarBL
    {
        public static List<RegistroBO> FiltrarPorNombre(List<RegistroBO> ListaRegistros, string Nombre)
        {
            return ListaRegistros.Where(p => p.Nombre.ToLower().Trim().Equals(Nombre.ToLower().Trim())).ToList();
        }

        public static List<RegistroBO> FiltrarPorRango(List<RegistroBO> ListaRegistros, double? min, double? max)
        {
            return ListaRegistros.Where(p => p.Respuesta >= min && p.Respuesta <= max).ToList();
        }

        public static List<RegistroBO> Filtrar(List<RegistroBO> ListaRegistros, string Nombre, double? min, double? max)
        {            
            if (!String.IsNullOrEmpty(Nombre))
            {
                ListaRegistros = FiltrarPorNombre(ListaRegistros, Nombre);
            }
            if (ValidarBL.Rango(min, max))
            {
                ListaRegistros = FiltrarPorRango(ListaRegistros, min, max);
            }
            return ListaRegistros;
        }
    }
}
