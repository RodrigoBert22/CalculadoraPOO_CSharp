using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaPrimeiraCalculadora.Operacoes
{
    public class Divisao : Operacao
    {
        public override double Calcular()
        {
            return PrimeiroValor / SegundoValor;
        }

        protected override void SetSegundoValor(double valor)
        {
            if (valor.Equals(0))
            {
                MessageBox.Show("Não é possível dividir por zero");
            }
            else
            {
                base.SetSegundoValor(valor);
            }
        }
        

    }
}

