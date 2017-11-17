using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class RegistroBO
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100, ErrorMessage = "Numero maximo de 100 Caracteres")]
        public string Nombre { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double Respuesta { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime FechaRegistro { get; set; }
    }
}
