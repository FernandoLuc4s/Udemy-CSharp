using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ConversaoDeMoeda
    {
        public static double Cotacao;
        public static double Dolares;

        public static double Resultado() {
            double result = Cotacao * Dolares;

            result += (result /100) * 6;

            return result;
        }
    }
}
