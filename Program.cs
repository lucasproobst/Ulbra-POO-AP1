using System;

namespace AP1
{
    public class Program
    {
        public static int Id { get; private set; }

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
                        Console.WriteLine("Informe os dados da compra:");
                        Console.WriteLine("Data:");
                        DateTime data = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o código de barras do produto:");
                        long codBarras = long.Parse(Console.ReadLine());

                        Produto produto = ProdutoRepositorio.get(codBarras);

                        Console.WriteLine("Informe o nome do fornecedor:");
                        string nomeFornecedor = Console.ReadLine();

                        /* Fornecedor fornecedor = FornecedorRepositorio.ObterPorId(1); */
                        /* Fornecedor fornecedor1 =  FornecedorRepositorio.get(); */

                        Compra compra = new Compra(Id, data, produto);

                        compra.RealizarCompra(produto);

                        Console.WriteLine("Compra realizada com sucesso!");

                        compra.ListarCompras();
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

        

