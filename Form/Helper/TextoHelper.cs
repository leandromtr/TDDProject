using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TDDProject
{
    public class TextoHelper
    {
        public static string GetNumeros(string texto)
        {
            return string.IsNullOrEmpty(texto) ? "" : new String(texto.Where(Char.IsDigit).ToArray());
        }
    }
}
