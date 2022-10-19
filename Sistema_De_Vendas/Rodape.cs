using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class Rodape
    {
        public decimal ValorTotal { get; set; }

        public Rodape()
        {
        }

        public Rodape(decimal valorTotal)
        {
            ValorTotal = valorTotal;
        }
    }
}
