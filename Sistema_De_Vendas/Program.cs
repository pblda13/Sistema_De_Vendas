using System;
using System.Collections.Generic;

namespace Sistema_De_Vendas
{
    class Program
    {
        enum Menu { PessoaFis = 1, PessoaJur = 2 }
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("");
            Console.WriteLine("1-PESSOA FISICA\n2-PESSOA JURIDICA ");
            Menu opcoes = (Menu)int.Parse(Console.ReadLine());
            var cliente = new List<Cliente>();
            

            if (opcoes == Menu.PessoaFis)
            {

                
                Console.WriteLine("Digite seu nome: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                var cpf = Console.ReadLine();
                var  pf1 = new PessoaFisica(nome,cpf);
                cliente.Add(pf1);

               

            }
            else
            {
                Console.WriteLine("Digite seu nome: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                var cnpj = Console.ReadLine();
                var pj1 = new PessoaJuridica(nome, cnpj);
                cliente.Add(pj1);
               
            }




            var produtos = new List<Produto>();

            Produto p1 = new Produto();
            Console.WriteLine("Produto: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Valor: ");
            p1.Preco = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            p1.Quantidade = Convert.ToInt32(Console.ReadLine());
            produtos.Add(p1);

            Produto p2 = new Produto();
            Console.WriteLine("Produto: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Valor: ");
            p2.Preco = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            p2.Quantidade = Convert.ToInt32(Console.ReadLine());
            produtos.Add(p2);





            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Imprimir(produtos,cliente);

           
        }
    }
}
