using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ValentinThourte
{
    internal class Numeracion
    {
        private ESistema sistema;
        private string valorNumerico;

        public ESistema Sistema { get; }
        public string Valor { get; }
        public Numeracion(double valor, ESistema sistema)
        {
            InicializarValores(valor.ToString(), sistema);
        }
        public Numeracion(string valor, ESistema sistema)
        {
            double numero;
            if (!double.TryParse(valor, out numero))
            {
                throw new ArgumentException($"El valor ingresado no es valido: {valor}");
            }
            InicializarValores(valor, sistema);
        }

        public string ConvertirA(ESistema sistema)
        {
            string numero = "";
            switch (sistema) {
                case ESistema.Binario:
                    {
                        numero = DecimalABinario(double.Parse(this.valorNumerico));
                        break;
                    }
                case ESistema.Decimal:
                    {
                        numero = BinarioADecimal(this.valorNumerico);
                        break;
                    }
            }
            return numero;
        }
        public static string DecimalABinario(double valor)
        {
            int number, index;
            int[] array = new int[10];
            Console.Write("Enter the number to convert: ");
            number = int.Parse(Console.ReadLine());
            for (index = 0; number > 0; index++)
            {
                array[index] = number % 2;
                number = number / 2;
            }
            string binario = "";
            foreach (var element in array)
            {
                binario += element.ToString();
            }
            return binario;
        }
        public static string BinarioADecimal(string valor)
        {
            int i;
            double returnNumber = 0;
            for(i = 0; i < valor.Length; i++)
            {
                returnNumber += double.Parse(valor[i].ToString()) * (Math.Pow(10, i));
            }
            return returnNumber.ToString();
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

        private void InicializarValores(string valor, ESistema sistema) 
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }
        
    }
}
