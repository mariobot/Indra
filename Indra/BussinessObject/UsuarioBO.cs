using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class UsuarioBO
    {
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(100, ErrorMessage = "Numero maximo de 100 Caracteres")]
        public string Nombre { get; set; }
        
        //[Required(ErrorMessage = "El Limite es requerido")]
        //[StringLength(5, ErrorMessage = "Numero maximo de 5 digitos")]
        //[Range(0, 99999, ErrorMessage = "Por favor ingrese un valor numerico entre 3 y 99999")]
        public int Limite { get; set; }
    }
}
