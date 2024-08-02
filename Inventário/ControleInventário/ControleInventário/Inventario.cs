using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventário
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }

    public class Inventario
    {
        private Dictionary<string, Produto> produtos;

        public Inventario()
        {
            produtos = new Dictionary<string, Produto>();
        }

        public void AdicionarProduto(string nome, int quantidade)
        {
            if (produtos.ContainsKey(nome))
            {
                produtos[nome].Quantidade += quantidade;
            }
            else
            {
                produtos[nome] = new Produto(nome, quantidade);
            }
        }

        public int GetQuantidade(string nome)
        {
            if (produtos.ContainsKey(nome))
            {
                return produtos[nome].Quantidade;
            }
            return 0;
        }
    }
}
