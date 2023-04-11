using System;

namespace AP1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de compras!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Cadastrar fornecedor");
                Console.WriteLine("4 - Listar fornecedores");
                Console.WriteLine("5 - Realizar compra");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe os dados do produto:");
                        ProdutoRepositorio.Adicionar();
                        Console.WriteLine("Produto cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Produtos cadastrados:");
                        ProdutoRepositorio.get();
                        break;

                    case 3:
                        Console.WriteLine("Informe os dados do fornecedor:");
                        FornecedorRepositorio.Adicionar();
                        Console.WriteLine("Fornecedor cadastrado com sucesso!");
                        break;

                    case 4:
                        Console.WriteLine("Fornecedores cadastrados:");
                        FornecedorRepositorio.ListarFornecedores();
                        break;

                    case 5:
                        Compra.ComecarCompra(0);
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por utilizar o sistema de compras!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}



