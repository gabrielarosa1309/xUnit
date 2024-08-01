using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        // AAA: Arrange, Act, Assert (agir, organizar e provar)

        [Fact]
        public void TestarMetodoSomar() 
        {
            // Arrange: organizar
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            // Act: agir
            var soma = Calculo.Somar(x1, x2);

            // Assert: provar
            Assert.Equal(valorEsperado, soma);
        }
    }
}
