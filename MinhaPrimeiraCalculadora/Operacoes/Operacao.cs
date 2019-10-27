using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraCalculadora.Operacoes
{
    public abstract class Operacao
    {
        private double _primeiroValor;
        private double _segundoValor;

        public double PrimeiroValor 
            { 
                get => _primeiroValor;
                set => SetPrimeiroValor(value); 
            }

        public double SegundoValor
            {
               get => _segundoValor;
               set => SetSegundoValor(value);
            }

        private void SetPrimeiroValor(double valor)
        {
            _primeiroValor = valor;
        }

        protected virtual void SetSegundoValor(double valor)
        {
            _segundoValor = valor;
        }

        public abstract double Calcular();


    }
}
