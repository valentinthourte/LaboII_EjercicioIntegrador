using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ValentinThourte
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando { get { return primerOperando; } set { primerOperando = value; } }
        public Numeracion SegundoOperando { get { return segundoOperando; } set { segundoOperando = value; } }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar(string operador)
        {
            return Operar(operador.FirstOrDefault());
        }
        public Numeracion Operar(char operador)
        {
            double resultadoNumerico;

            switch (operador)
            {

                case '-':
                    {
                        resultadoNumerico = primerOperando - segundoOperando;
                        break;
                    }
                case '*':
                    {
                        resultadoNumerico = primerOperando * segundoOperando;
                        break;
                    }
                case '/':
                    {
                        resultadoNumerico = primerOperando / segundoOperando;
                        break;
                    }
                case '+':
                default:
                    {
                        resultadoNumerico = primerOperando + segundoOperando;
                        break;
                    }
            }
            return new Numeracion(resultadoNumerico, ESistema.Decimal);
        }

        public void ActualizarOperandos(Numeracion primerOperando, Numeracion segundoOperando)
        {
            if (PrimerOperando.Valor != primerOperando.Valor)
            {
                PrimerOperando.ActualizarValor(primerOperando);
            }
            if (SegundoOperando.Valor != segundoOperando.Valor)
            {
                SegundoOperando.ActualizarValor(primerOperando);
            }
        }
    }
}
