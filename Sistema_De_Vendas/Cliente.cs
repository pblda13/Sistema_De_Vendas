using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class Cliente
    {
        public string Nome { get; set; }

         public Cliente()
        {
        } 

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
