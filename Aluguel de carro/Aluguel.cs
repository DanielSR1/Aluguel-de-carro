using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel_de_carro
{
    public class Aluguel
    {
        public static double alugar(double dias, double inicial, double final)
        {
            return (dias * 95) + ((final - inicial) * 0.35);
        }
    }
}
