using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ValentinThourte
{
    internal class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando { get; set; }
        public Numeracion SegundoOperando { get; set; }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '+':
                    {

                        break;
                    }
                case '-':
                    {
                        break;
                    }
                case '*':
                    {
                        break;
                    }
                case '/':
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

    }
}
