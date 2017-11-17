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
        public int AlmacenarRegistro(UsuarioBO _usuarioBO)
        {
            try
            {
                RegistroDA _registroDA = new RegistroDA();
                RegistroBO _registroBO = new RegistroBO();

                _registroBO.FechaRegistro = DateTime.Now;
                _registroBO.Nombre = _usuarioBO.Nombre;
                _registroBO.Respuesta = _usuarioBO.Limite;

                var result = _registroDA.AdicionarRegistro(_registroBO);

                return 1;
            }

            catch
            {
                throw;
            }
        }
    }
}
