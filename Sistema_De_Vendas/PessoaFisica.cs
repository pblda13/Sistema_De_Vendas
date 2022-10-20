using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        

        public PessoaFisica()
        {

        }
        public PessoaFisica(string nome, string cpf) : base (nome)
        {
            Nome = nome;
            CPF = cpf;
        }


    }


}
