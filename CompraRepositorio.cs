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

        public IEnumerable<Compra> ListarCompras()
        {
            return _compras;
        }

        public Compra ObterCompraPorId(int id)
        {
            return _compras.FirstOrDefault(c => c.Id == id);
        }

        private int ProximoId()
        {
            return _compras.Count + 1;
        }
    }
}
