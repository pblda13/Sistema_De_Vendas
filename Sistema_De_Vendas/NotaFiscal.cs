using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_De_Vendas
{
    class NotaFiscal
    {
        public Cabecalho cabecalho { get; set; }
        public List<Produto> produto { get; set; }
        public Rodape rodape { get; set; }


        public void Imprimir()
        {
             
           
            /* Console.WriteLine("=================== NOTA FISCAL DE SAIDA =========================");
            Console.WriteLine();
            Console.WriteLine($"Numero: {cabecalho.NumeroNota} ");
            Console.WriteLine($"Cliente: {cabecalho.cliente.Nome.ToUpper()}");
            Console.WriteLine($"CPF:  ");


            Console.WriteLine();

            decimal soma = 0;
            Console.WriteLine($"Produto:       Quantidade:         Preço: ");
            foreach (var item in produto)
            {
                Console.WriteLine($"{item.Nome}            {item.Quantidade}              {item.Preco}");
                soma = soma + item.Preco * item.Quantidade;
            }
            Console.WriteLine();
            Console.WriteLine($"Total da Nota Fiscal: {soma} ");
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
 */

        }
    }
}
