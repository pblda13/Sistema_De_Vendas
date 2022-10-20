using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class NotaFiscal
    {
        public Cabecalho cabecalho { get; set; } = new Cabecalho();
        public List<Produto> produto { get; set; } = new List<Produto>();
        public Rodape rodape { get; set; } = new Rodape();


        public NotaFiscal()
        {

        }
        public NotaFiscal(Cabecalho cabecalho, List<Produto> produtos, Rodape rodape)
        {
            this.cabecalho = cabecalho;
            this.produto = produtos;
            this.rodape = rodape;
        }
        public void Imprimir(List<Produto> produtos,List<Cliente>clientes)
        {
            Console.WriteLine("=================== NOTA FISCAL DE SAIDA =========================");
            Console.WriteLine();
            Console.WriteLine($"Numero: {cabecalho.NumeroNota} ");
            foreach(PessoaFisica cl in clientes)
            {
                Console.WriteLine($"Cliente: {cl.Nome}");
                Console.WriteLine($"CPF: {cl.CPF}  ");
            }
            Console.WriteLine();

            decimal soma = 0;
            Console.WriteLine($"Produto:                Quantidade:         Preço: ");
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}            {item.Quantidade}            {item.Preco.ToString("C")}");
                soma = soma + item.Preco * item.Quantidade;
            }
            Console.WriteLine();
            Console.WriteLine($"Total da Nota Fiscal: {soma.ToString("C")} ");
            Console.WriteLine();
            Console.WriteLine("=========================================================================");


        }
    }
}
