using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class ConsultaUsuarioBO
    {
        
        [StringLength(100, ErrorMessage = "Numero maximo de 100 Caracteres")]
        public string Nombre { get; set; }
        
        [Range(0, 9999999999, ErrorMessage = "Por favor ingrese un valor numerico entre 3 y 99999")]
        public int Minima { get; set; }
        
        [Range(0, 9999999999, ErrorMessage = "Por favor ingrese un valor numerico entre 3 y 99999")]
        public int Maxima { get; set; }
    }
}
