using System;
using System.Windows.Forms;

namespace MinhaPrimeiraCalculadora
{
    public partial class FormCalculadora : Form
    {

        private Calculadora _calculadora;
        private bool _subTotalSolicitado;

        public FormCalculadora()
        {
            InitializeComponent();
            _calculadora = new Calculadora();
        }

        private void btn_NumeroClick(object sender, System.EventArgs e)
        {
            var valorBotao = CapturarValorDoBotao(sender);
            IncrementarDisplay(valorBotao);
        }

        private void IncrementarDisplay(string valorBotao)
        {
            TratarZeroAEsquerda();

            if (_subTotalSolicitado)
            {
                AtualizarDisplay(valorBotao);
                _subTotalSolicitado = false;
            }
            else
            {
                tbDisplay.Text += valorBotao;
            }
        }

        private void AtualizarDisplay(string valorBotao)
        {
            tbDisplay.Text = valorBotao;
        }

        private string CapturarValorDoBotao(object sender)
        {
            var btnSender = (Button) sender;
            return btnSender.Text;
        }

        private void TratarZeroAEsquerda()
        {
            var valorDoDisplay = CapturarValorDoDisplay();

            var novoValor = valorDoDisplay.StartsWith("0") 
                ? valorDoDisplay.Remove(0) 
                : valorDoDisplay;

            AtualizarDisplay(novoValor);
        }

        private string CapturarValorDoDisplay()
        {
            return tbDisplay.Text;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            ZerarDisplay();
        }

        private void ZerarDisplay()
        {
            AtualizarDisplay("0");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ZerarDisplay();
            _calculadora.LimparOperacao();
        }

        private void btn_OperacaoClick(object sender, EventArgs e)
        {
            var valorBotao = CapturarValorDoBotao(sender);
            _calculadora.DefinirOperacao(valorBotao);

            var valorDisplay = CapturarValorDoDisplay();
            _calculadora.DefinirValorDaOperacao(valorDisplay);

            var subTotal = _calculadora.SubTotal();

            _subTotalSolicitado = true;

            AtualizarDisplay(subTotal.ToString());
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            var valorDisplay = CapturarValorDoDisplay();
            _calculadora.DefinirValorDaOperacao(valorDisplay);

            var total = _calculadora.CalcularTotal();

            _subTotalSolicitado = false;

            AtualizarDisplay(total.ToString());
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            var valorDoDisplay = CapturarValorDoDisplay();

            var novoValor = valorDoDisplay.Length > 1
                ? valorDoDisplay.Remove(valorDoDisplay.Length - 1)
                : "0";

            AtualizarDisplay(novoValor);
        }
    }
}
