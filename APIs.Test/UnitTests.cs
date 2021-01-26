using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace APIs.Test
{
    public class UnitTests
    {
        [Theory]
        [InlineData(100, 1, 0.01, 1)]
        [InlineData(200, 1, 0.01, 2)]
        [InlineData(100, 12, 0.01, 12.68)]
        public void CalcularJurosTest(decimal valorInicial, int tempo, decimal taxaJuros, decimal resultado)
        {
            Assert.Equal(Math.Round(resultado, 2), Math.Round(Juros.CalcularJuros(valorInicial, tempo, taxaJuros), 2));
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-100)]
        public void ValorInvalidoTest(decimal valorInicial)
        {
            Assert.Throws<ArgumentException>(() => Juros.CalcularJuros(valorInicial, 1, 0.01M));
        }
    }
}
