using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using DataAccess;

namespace BussinessLoyic
{
    public class RegistroBL
    {
        public double AlmacenarRegistro(UsuarioBO _usuarioBO)
        {
            try
            {
                RegistroDA _registroDA = new RegistroDA();
                RegistroBO _registroBO = new RegistroBO();

                _registroBO.FechaRegistro = DateTime.Now;
                _registroBO.Nombre = _usuarioBO.Nombre;
                _registroBO.Respuesta = CalcularBL.Numero(_usuarioBO.Limite);

                var result = _registroDA.AdicionarRegistro(_registroBO);

                return _registroBO.Respuesta;
            }

            catch
            {
                throw;
            }
        }

        public List<RegistroBO> TotalRegistros()
        {
            RegistroDA _registroDA = new RegistroDA();

            return _registroDA.TodosLosRegistros(); 
        }

        public void EliminarRegistro(RegistroBO _registroBO)
        {
            RegistroDA _registroDA = new RegistroDA();

            _registroDA.EliminarRegistro(_registroBO);

            return;
        }
    }
}
