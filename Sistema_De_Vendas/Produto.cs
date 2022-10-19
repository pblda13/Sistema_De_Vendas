using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, decimal preço, int quantidade)
        {
            Nome = nome;
            Preco = preço;
            Quantidade = quantidade;
        }

        public decimal Total()
        {
            decimal precoTotal = Quantidade * Preco;

            return precoTotal;
        }
    }
}
