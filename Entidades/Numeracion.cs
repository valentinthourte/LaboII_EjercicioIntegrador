using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ValentinThourte
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public ESistema Sistema { get; }
        public string Valor
        {
            get
            {
                return GetValor();
            }
        }

        private string GetValor()
        {
            string retorno;
            switch (sistema)
            {
                case ESistema.Binario:
                    {
                        retorno = DecimalABinario(valorNumerico);
                        break;
                    }
                case ESistema.Decimal:
                default:
                    {
                        retorno = valorNumerico.ToString();
                        break;
                    }
            }
            return retorno;
        }

        public Numeracion(double valor, ESistema sistema)
        {
            InicializarValores(valor.ToString(), sistema);
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        public string ConvertirA(ESistema sistema)
        {
            ESistema sistemaViejo = this.Sistema;
            this.sistema = sistema;
            string valorDevolver = Valor;
            this.sistema = sistemaViejo;
            return valorDevolver;
        }

        public static string DecimalABinario(double valor)
        {
            int index;
            double valorAbsoluto = Math.Abs(valor);
            List<int> doubles = new List<int>();
            for (index = 0; valorAbsoluto > 1; index++)
            {
                doubles.Add((int)valorAbsoluto % 2);
                valorAbsoluto = valorAbsoluto / 2;
            }
            string binario = "";
            bool sonTodosCero = true;
            foreach (var element in doubles)
            {
                if (element != 0)
                {
                    sonTodosCero = false;
                }
                binario = element.ToString() + binario;
            }

            if(valorAbsoluto > 0 && sonTodosCero)
            {
                binario = "1" + binario;
            }

            return binario;
        }

        public static string DecimalABinario(string valor)
        {
            if (!double.TryParse(valor, out double result))
            {
                throw new EInvalidArgumentException("El texto ingresado no es un valor númerico válido.");
            }
            return Numeracion.DecimalABinario(result);
        }

        public static double BinarioADecimal(string valor)
        {
            int i;
            double returnNumber = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int binarioLength = valor.Length;
            for (i = 0; i < binarioLength; i++)
            {
                char binaryChar = valor[binarioLength - 1 - i];
                int binaryDigit = binaryChar - '0';
                returnNumber += binaryDigit * (Math.Pow(2, i));
            }
            return returnNumber;
        }

        public static bool EsBinario(string valor)
        {
            bool esBinario = true;
            List<string> caracteresBinarios = new List<string> { "0", "1" };
            int i = 0;
            while (esBinario && i < valor.Length)
            {
                string caracter = valor[i].ToString();
                if (!caracteresBinarios.Contains(caracter))
                {
                    esBinario = false;
                }
                i++;
            }
            return esBinario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        /// <exception cref="EInvalidArgumentException"></exception>
        private void InicializarValores(string valor, ESistema sistema)
        {
            double valorNumerico;

            if (EsBinario(valor) && sistema is ESistema.Binario)
            {
                valorNumerico = BinarioADecimal(valor);
            }
            else if (!double.TryParse(valor, out valorNumerico))
            {
                valorNumerico = double.MinValue;
            }



            this.valorNumerico = valorNumerico;
            this.sistema = sistema;
        }

        public void ActualizarValor(Numeracion numeracion)
        {
            this.valorNumerico = numeracion.valorNumerico;
        }
        public void ActualizarValor(double valor)
        {
            this.valorNumerico = valor;
        }
        public void ActualizarValor(string valor)
        {
            double.TryParse(valor, out this.valorNumerico);
        }

        public static double operator +(Numeracion numero1, Numeracion numero2)
        {
            return double.Parse(numero1.ConvertirA(ESistema.Decimal)) + double.Parse(numero2.ConvertirA(ESistema.Decimal));
        }
        public static double operator -(Numeracion numero1, Numeracion numero2)
        {
            return double.Parse(numero1.ConvertirA(ESistema.Decimal)) - double.Parse(numero2.ConvertirA(ESistema.Decimal));
        }
        public static double operator *(Numeracion numero1, Numeracion numero2)
        {
            return double.Parse(numero1.ConvertirA(ESistema.Decimal)) * double.Parse(numero2.ConvertirA(ESistema.Decimal));
        }
        public static double operator /(Numeracion numero1, Numeracion numero2)
        {
            return double.Parse(numero1.ConvertirA(ESistema.Decimal)) / double.Parse(numero2.ConvertirA(ESistema.Decimal));
        }
        public static bool operator ==(Numeracion numero1, Numeracion numero2) => numero1.Sistema == numero2.Sistema;
        public static bool operator !=(Numeracion numero1, Numeracion numero2) => numero1.Sistema != numero2.Sistema;
        public static bool operator ==(Numeracion numero1, ESistema sistema) => numero1.Sistema == sistema;
        public static bool operator !=(Numeracion numero1, ESistema sistema) => numero1.Sistema != sistema;
    }
}
