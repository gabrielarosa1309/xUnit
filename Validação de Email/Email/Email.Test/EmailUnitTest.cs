using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Test
{
    public class ValidacaoUnitTest
    {
        [Theory]
        [InlineData("user@email.com", true)]
        [InlineData("user.email.com", false)]
        [InlineData("user@email", false)]
        [InlineData("user@.com", false)]
        [InlineData("user@email.com.br", true)]
        [InlineData("user@email..com", true)]  
        [InlineData("user@email.com.", true)]  
        public void TestarMetodoValidarEmail(string email, bool resultadoEsperado)
        {
            // Act: agir
            var resultado = Validacao.ValidarEmail(email);

            // Assert: provar
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
