using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        public static bool TeclaPresionadaEsNumero(char tecla, char[] caracteresPermitidos)
        {
            return !(char.IsDigit(tecla)) || (caracteresPermitidos.ToList().Contains(tecla));
        }
    }
}