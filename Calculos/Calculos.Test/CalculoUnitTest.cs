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

        //[Fact]
        //public void TestarMetodoSomar() 
        //{
        //    // Arrange: organizar
        //    var x1 = 4.1;
        //    var x2 = 5.9;
        //    var valorEsperado = 10;

        //    // Act: agir
        //    var soma = Calculo.Somar(x1, x2);

        //    // Assert: provar
        //    Assert.Equal(valorEsperado, soma);
        //}

        //[Fact]
        //public void TestarMetodoSubtrair()
        //{
        //    // Arrange: organizar
        //    var x1 = 7;
        //    var x2 = 3;
        //    var valorEsperado = 4;

        //    // Act: agir
        //    var subtracao = Calculo.Subtrair(x1, x2);

        //    // Assert: provar
        //    Assert.Equal(valorEsperado, subtracao);
        //}

        //[Fact]
        //public void TestarMetodoDividir()
        //{
        //    // Arrange: organizar
        //    var x1 = 9;
        //    var x2 = 3;
        //    var valorEsperado = 3;

        //    // Act: agir
        //    var divisao = Calculo.Dividir(x1, x2);

        //    // Assert: provar
        //    Assert.Equal(valorEsperado, divisao);
        //}

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            // Arrange: organizar
            var x1 = 9;
            var x2 = 8;
            var valorEsperado = 72;

            // Act: agir
            var multiplicacao = Calculo.Multiplicar(x1, x2);

            // Assert: provar
            Assert.Equal(valorEsperado, multiplicacao);
        }
    }
}
