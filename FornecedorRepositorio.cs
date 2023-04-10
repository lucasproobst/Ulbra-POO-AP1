using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class FornecedorRepositorio
    {
        public static List<Fornecedor> _fornecedores = new List<Fornecedor>();
        private static readonly string nomeFornecedor;

        public static void Adicionar()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("CNPJ: ");
            float cnpj = float.Parse(Console.ReadLine());

            Fornecedor fornecedor = new Fornecedor(nomeFornecedor, cnpj, nome);

            _fornecedores.Add(fornecedor);
        }

        public IEnumerable<Fornecedor> Listar()
        {
            return _fornecedores;
        }

        public static Fornecedor ObterPorId(int id)
        {
            return _fornecedores.FirstOrDefault(f => f.Id == id);
        }

        public static int ProximoId()
        {
            int id = 0;
            return id + 1;
        }

        public static void ListarFornecedores()
        {
            if (_fornecedores.Count == 0)
            {
                Console.WriteLine("\nNenhum fornecedor cadastrado!");
            }
            else
            {
                foreach (var fornecedor in _fornecedores)
                {
                    Console.WriteLine($"\nFornecedor: {fornecedor.Nome} | CNPJ: {fornecedor.Cnpj}");
                }
            }
        }
    }
}