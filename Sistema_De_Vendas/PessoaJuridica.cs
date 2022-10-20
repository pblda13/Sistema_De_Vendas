using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class PessoaJuridica : Cliente
    {
        public String CNPJ { get; set; }


        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string cnpj, string nome)
        {
            Nome = nome;
            CNPJ = cnpj;
        }
    }


}
