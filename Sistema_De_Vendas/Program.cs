using System;
using System.Collections.Generic;

namespace Sistema_De_Vendas
{
    class Program
    {
        enum Menu { PessoaFis = 1, PessoaJur = 2 }
        static void Main(string[] args)
        {

            System.Console.WriteLine("1- PESSOA FISICA  OU 2- JURUDICA ?");
            Menu opcoes = (Menu)int.Parse(Console.ReadLine());
            //var cliente = new List<Cliente>();
            Cliente pf1 = new PessoaFisica();
            //var pessoaf = new List<PessoaFisica>();
             //PessoaFisica pf1 = new PessoaFisica();

            if (opcoes == Menu.PessoaFis)
            {

                //PessoaFisica pf1 = new PessoaFisica();
                Console.WriteLine("Digite seu nome: ");
                pf1.Nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                ((PessoaFisica)pf1).CPF = Console.ReadLine();
                //pessoaf.Add(pf1);

            }
            else
            {
                var pj1 = new PessoaJuridica();
                Console.WriteLine("Digite seu nome: ");
                pj1.Nome = Console.ReadLine();
                Console.WriteLine("Digite seu CNPJ: ");
                pj1.CNPJ = Console.ReadLine();
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
            Cabecalho cabecalho = new Cabecalho();


            notaFiscal.Imprimir();

            Console.WriteLine("=================== NOTA FISCAL DE SAIDA =========================");
            Console.WriteLine();
            Console.WriteLine($"Numero: {cabecalho.NumeroNota} ");
            Console.WriteLine($"Cliente: {pf1.Nome}");
            Console.WriteLine($"CPF:{ ((PessoaFisica)pf1).CPF}  ");
            

            Console.WriteLine();

            decimal soma = 0;
            Console.WriteLine($"Produto:       Quantidade:         Preço: ");
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome}            {item.Quantidade}              {item.Preco}");
                soma = soma + item.Preco * item.Quantidade;
            }
            Console.WriteLine();
            Console.WriteLine($"Total da Nota Fiscal: {soma} ");
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
        }
    }
}
