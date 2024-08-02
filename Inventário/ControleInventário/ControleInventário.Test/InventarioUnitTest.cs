using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventário.Test
{
    public class InventarioUnitTest
    {
        //[Fact]
        //public void TestarMetodoAdicionarProdutoNovo()
        //{
        //    // Arrange: organizar
        //    var inventario = new Inventario();
        //    var nomeProduto = "Caneta";
        //    var quantidadeProduto = 10;

        //    // Act: agir
        //    inventario.AdicionarProduto(nomeProduto, quantidadeProduto);
        //    var quantidadeAtual = inventario.GetQuantidade(nomeProduto);

        //    // Assert: provar
        //    Assert.Equal(quantidadeProduto, quantidadeAtual);
        //}

        //[Fact]
        //public void TestarMetodoIncrementarQuantidadeProdutoExistente()
        //{
        //    // Arrange: organizar
        //    var inventario = new Inventario();
        //    var nomeProduto = "Caneta";
        //    var quantidadeInicial = 10;
        //    var quantidadeAdicional = 5;
        //    inventario.AdicionarProduto(nomeProduto, quantidadeInicial);

        //    // Act: agir
        //    inventario.AdicionarProduto(nomeProduto, quantidadeAdicional);
        //    var quantidadeAtual = inventario.GetQuantidade(nomeProduto);

        //    // Assert: provar
        //    Assert.Equal(quantidadeInicial + quantidadeAdicional, quantidadeAtual);
        //}

        [Fact]
        public void TestarMetodoObterQuantidadeProdutoNaoExistente()
        {
            // Arrange: organizar
            var inventario = new Inventario();
            var nomeProduto = "Lápis";

            // Act: agir
            var quantidadeAtual = inventario.GetQuantidade(nomeProduto);

            // Assert: provar
            Assert.Equal(0, quantidadeAtual);
        }
    }
}
