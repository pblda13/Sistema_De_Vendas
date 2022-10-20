using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class Cabecalho
    {
        public Guid NumeroNota = Guid.NewGuid();
        public Cliente cliente {get;set;}= new Cliente();

        public Cabecalho()
        {
        }

        public Cabecalho(Guid numeroNota, Cliente cliente)
        {
            NumeroNota = numeroNota;
            this.cliente = cliente;
        }
    }
}
