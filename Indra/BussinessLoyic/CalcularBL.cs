using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLoyic
{
    public static class CalcularBL
    {
        public static double Numero(double limite)
        {
            int total = 0;

            for (int i = 0; i <= limite; i++)
            {
                if ((i%3)==0||(i%5)==0)
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
