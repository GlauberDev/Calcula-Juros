using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.ViewModels
{
    public class CalcularJurosViewModel
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }

        public CalcularJurosViewModel(decimal ValorInicial, int Tempo)
        {
            this.ValorInicial = ValorInicial;
            this.Tempo = Tempo;
        }
    }
}
