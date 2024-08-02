using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao.Test
{
    public class ConversaoUnitTest
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
        [InlineData(37, 98.6)]
        [InlineData(25, 77)]
        [InlineData(-273.15, -459.67)]
        public void TestarMetodoCelsiusParaFahrenheit(double celsius, double resultadoEsperado)
        {
            // Act: agir
            var resultado = ConversaoTemperatura.CelsiusParaFahrenheit(celsius);

            // Assert: provar
            Assert.Equal(resultadoEsperado, resultado, precision: 2);
        }
    }
}
