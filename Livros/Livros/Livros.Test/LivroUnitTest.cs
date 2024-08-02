using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Test
{
    public class BibliotecaUnitTest
    {
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            // Arrange: organizar
            var biblioteca = new Biblioteca();
            var livro = new Livro("Jantar Secreto", "Raphael Montes");

            // Act: agir
            biblioteca.AdicionarLivro(livro);
            var livros = biblioteca.GetLivros();

            // Assert: provar
            Assert.Contains(livro, livros);
        }
    }
}
