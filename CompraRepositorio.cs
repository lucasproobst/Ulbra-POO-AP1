using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class CompraRepositorio
    {
        private readonly List<Compra> _compras = new List<Compra>();

        public void RealizarCompra(Produto produtos)
        {
            int id = ProximoId();
            DateTime data = DateTime.Now;

            Compra compra = new Compra(id, data, produtos);

            _compras.Add(compra);
        }

        public static void ComecarCompra(int id)
        {
            Console.WriteLine("Informe os dados da compra:");
            Console.WriteLine("Data:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código de barras do produto:");
            long codBarras = long.Parse(Console.ReadLine());

            Produto produto = ProdutoRepositorio.get(codBarras);

            Console.WriteLine("Informe o nome do fornecedor:");
            string nomeFornecedor = Console.ReadLine();

            Compra compra = new Compra(id, data, produto);

            compra.RealizarCompra(produto);

            Console.WriteLine("Compra realizada com sucesso!");
        }

        public IEnumerable<Compra> ListarCompras()
        {
            return _compras;
        }

        public Compra ObterCompraPorId(int id)
        {
            return _compras.FirstOrDefault(c => c.Id == id);
        }

        public int ProximoId()
        {
            return _compras.Count + 1;
        }
    }
}
