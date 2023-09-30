using Entidades;

namespace Calculadora_ValentinThourte
{
    public partial class frmCalculadora : Form
    {
        const string TEXTO_RESULTADO = "Resultado: ";

        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion? resultado;

        public string OperacionSeleccionada { get { return (string)cbOperacion.SelectedItem ?? ""; } }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operar();
        }

        private void Operar()
        {
            try
            {
                ActualizarOperandos();
                resultado = calculadora.Operar(OperacionSeleccionada);
                setResultado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarOperandos()
        {
            string primerValorIngresado = tbPrimerOperador.Text;
            string segundoValorIngresado = tbSegundoOperador.Text;
            ActualizarOperando(primerOperando, primerValorIngresado);
            ActualizarOperando(segundoOperando, segundoValorIngresado);
            calculadora.ActualizarOperandos(primerOperando, segundoOperando);
        }

        private void setResultado()
        {
            string resultadoString = "";
            if (!(resultado is null))
            {
                resultadoString = this.resultado.ConvertirA(ObtenerSistema());
            }
            this.lblResultado.Text = $"{TEXTO_RESULTADO}{resultadoString}";
        }

        private ESistema ObtenerSistema()
        {
            ESistema sistemaResultado = ESistema.Decimal;
            if (rbBinario.Checked)
            {
                sistemaResultado = ESistema.Binario;
            }
            return sistemaResultado;
        }

        private void tbOperadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validador.TeclaPresionadaEsNumero(e.KeyChar);
        }

        private void tbPrimerOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void ActualizarOperando(Numeracion operando, string valorIngresado)
        {
            if (double.TryParse(valorIngresado, out double result))
            {
                operando.ActualizarValor(result);
            }
            else
            {
                throw new Exception($"El valor {valorIngresado} no es válido. Inténtelo nuevamente.");
            }
        }

        private double NumeroPrimerOperador()
        {
            try
            {
                return double.Parse(tbPrimerOperador.Text);
            }
            catch (Exception e)
            {
                throw new Exception($"El valor del primer operador no pudo ser convertido a double: {e.GetType()}: {e.Message}");
            }
        }
        private double NumeroSegundoOperador()
        {
            try
            {
                return double.Parse(tbSegundoOperador.Text);
            }
            catch (Exception e)
            {
                throw new Exception($"El valor del segundo operador no pudo ser convertido a double: {e.GetType()}: {e.Message}");
            }
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(NumeroPrimerOperador(), ESistema.Decimal);
            segundoOperando = new Numeracion(NumeroSegundoOperador(), ESistema.Decimal);
            calculadora = new Operacion(primerOperando, segundoOperando);
        }

        private void tbSegundoOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            this.tbPrimerOperador.Clear();
            this.tbSegundoOperador.Clear();
            this.resultado = null;

            setResultado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CorrespondeCerrar()
        {
            string mensaje = "Está seguro que quiere cerrar el programa?";
            string titulo = "Cerrar programa";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            return MessageBox.Show(mensaje, titulo, buttons: botones) == DialogResult.Yes;
        }

        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            setResultado();
        }

        private void rbBinario_CheckedChanged(object sender, EventArgs e)
        {
            setResultado();
        }

        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CorrespondeCerrar();
        }
    }
}