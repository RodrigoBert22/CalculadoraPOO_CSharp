using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraCalculadora.Operacoes
{
    public class Soma : Operacao
    {
        public override double Calcular()
        {
            return PrimeiroValor + SegundoValor;
        }
    }
}
