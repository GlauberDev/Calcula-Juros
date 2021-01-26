using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs
{
    public class Juros
    {
        public static decimal CalcularJuros(decimal valorInicial, int tempo, decimal taxaJuros)
        {
            if (valorInicial > 0)
                return valorInicial * ((decimal)Math.Pow((double)(1 + taxaJuros), tempo) - 1);
            else
                throw new ArgumentException();
        }

    }
}
