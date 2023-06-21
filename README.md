# Aplicação de Emissão de Nota Fiscal

Bem-vindo à aplicação de Emissão de Nota Fiscal! Este é um sistema de console que permite o cadastro de dados de venda e a impressão da Nota Fiscal correspondente. Siga as instruções abaixo para utilizar a aplicação corretamente.

## Classes e Hierarquia

A aplicação é composta pelas seguintes classes:

- **Cliente**: Classe base que representa um cliente genérico.
- **Pessoa Física**: Classe derivada de Cliente, que representa um cliente pessoa física.
- **Pessoa Jurídica**: Classe derivada de Cliente, que representa um cliente pessoa jurídica.
- **Produto**: Classe que representa um produto vendido.
- **Cabeçalho**: Classe que define o cabeçalho da Nota Fiscal.
- **Rodapé**: Classe que define o rodapé da Nota Fiscal.
- **Nota Fiscal**: Classe que representa a Nota Fiscal de venda.

## Requisitos do Sistema

- Ambiente de desenvolvimento compatível com a linguagem utilizada (Visual Studio, Visual Studio Code).
- Linguagem de programação compatível com a aplicação C#.
- Compilador ou interpretador da linguagem escolhida devidamente instalado.

## Como Usar

1. Faça o download ou clone o repositório da aplicação do GitHub: [URL do repositório].

2. Abra o ambiente de desenvolvimento e importe o projeto da aplicação.

3. Navegue até a classe do programa principal (por exemplo, `Program.cs` ).

4. Instancie um objeto da classe `NotaFiscal`.

5. Crie uma tela de cadastro para que o usuário insira os dados da venda, incluindo informações sobre o cliente e pelo menos dois produtos vendidos.

6. Ao finalizar o cadastro da venda, chame o método `Imprimir` da instância da classe `NotaFiscal` para exibir a Nota Fiscal no console.

## Exemplo de Impressão da Nota Fiscal

A impressão da Nota Fiscal seguirá um formato semelhante ao exemplo abaixo:

```
---------------------------------
         NOTA FISCAL
---------------------------------
Cliente: [Nome do Cliente]
CPF/CNPJ: [CPF ou CNPJ do Cliente]
---------------------------------
Itens Vendidos:
1. [Nome do Produto 1] - R$ [Valor Unitário 1]
   Quantidade: [Quantidade 1]
   Subtotal: R$ [Subtotal 1]
   
2. [Nome do Produto 2] - R$ [Valor Unitário 2]
   Quantidade: [Quantidade 2]
   Subtotal: R$ [Subtotal 2]
   
---------------------------------
Total: R$ [Valor Total]
---------------------------------
```

## Contribuição

Este projeto foi desenvolvido pela Pâmela Borges. Se você identificar algum problema ou desejar contribuir para o projeto, fique à vontade para abrir uma issue ou enviar um pull request no repositório do GitHub.

## Suporte

Esperamos que a aplicação de Emissão de Nota Fiscal seja útil para você. Aproveite e boa venda!
