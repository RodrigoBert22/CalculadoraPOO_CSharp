using MinhaPrimeiraCalculadora.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaPrimeiraCalculadora
{
    public class Calculadora
    {
        private Operacao _operacao;
        private string _primeiroValor;
        private string _segundoValor;

        public void DefinirOperacao(string sinalDaOperacao)
        {
            _operacao = GetOperacao(sinalDaOperacao);
        }

        public void DefinirValorDaOperacao(string valor)
        {
            if (string.IsNullOrEmpty(_primeiroValor) || _primeiroValor.Equals("0"))
            {
                _primeiroValor = valor;
            }
            else
            {
                _segundoValor = valor;
            }
        }

        private Operacao GetOperacao(string sinalDaOperacao)
        {
            switch (sinalDaOperacao)
            {
                case "+":
                    return new Soma();
                case "-":
                    return new Subtracao();
                case "*":
                    return new Multiplicacao();
                case "/":
                    return new Divisao();
                default:
                    MessageBox.Show("Operação inválida");
                    return null;             
            }
        }

        private void DefinirPrimeiroValorDaOperacao()
        {
            _operacao.PrimeiroValor = Convert.ToDouble(_primeiroValor);
        }

        private void DefinirSegundoValorDaOperacao()
        {
            _operacao.SegundoValor = Convert.ToDouble(_segundoValor);
        }

        public double CalcularTotal()
        {
            if (_operacao is null) return 0;

            DefinirPrimeiroValorDaOperacao();
            DefinirSegundoValorDaOperacao();

            var resultado = _operacao.Calcular();

            LimparOperacao();

            return resultado;
        }

        public double SubTotal()
        {
            DefinirPrimeiroValorDaOperacao();

            if (string.IsNullOrEmpty(_segundoValor)) return _operacao.PrimeiroValor;

            DefinirSegundoValorDaOperacao();

            var subTotal = _operacao.Calcular();

            _primeiroValor = subTotal.ToString();
            _segundoValor = null;

            return subTotal;

        }

        public void LimparOperacao()
        {
            _operacao = null;
            _primeiroValor = null;
            _segundoValor = null;
        }


    }
}
