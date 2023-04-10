using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoRepositorio : Produto
    {
        private static List<Produto> _produtos = new List<Produto>();

        public ProdutoRepositorio(long codBarras, string nome, string valor, string marca, Fornecedor fornecedor) : base(codBarras, nome, valor, marca, fornecedor)
        { }

        public static void Adicionar()
        {
            Console.WriteLine("Codigo de barra: ");
            long codBarras = long.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine());
            string valorStr = valor.ToString();

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Fornecedor: ");
            string nomeFornecedor = Console.ReadLine();

            Console.WriteLine("Cnpj Fornecedor: ");
            float cnpj = float.Parse(Console.ReadLine());
            string cnpjStr = cnpj.ToString();

            Fornecedor fornecedor = new Fornecedor(nomeFornecedor, cnpj, nome);

            ProdutoSimples produtoSimples = new ProdutoSimples(codBarras, nome, valor.ToString(), marca, fornecedor);

            _produtos.Add(produtoSimples);
        }

        public static void get()
        {
            if (_produtos == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach (var c in _produtos)
            {
                Console.WriteLine($"\nCódigo de barras: {c.CodBarras} | Nome: {c.Nome} | Valor: {c.Valor} | Marca: {c.Marca}");
            }
        }
        public class Listar
        {
            public static void Produtos(List<Produto> produtos)
            {
                if (produtos == null)
                {
                    System.Console.WriteLine("\nNenhum produto cadastrado!");
                }
                foreach (var c in produtos)
                {
                    Console.WriteLine($"\nCódigo de barras: {c.CodBarras} | Nome: {c.Nome} | Valor: {c.Valor} | Marca: {c.Marca}");
                }
            }
        }
        public static void ListarProdutos()
        {
            Listar.Produtos(_produtos);
        }
        public static Produto get(long codBarras)
        {
            if (_produtos == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }

            return _produtos.Find(p => p.CodBarras == codBarras);
        }
    }
}

