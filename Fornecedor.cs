using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Fornecedor : FornecedorRepositorio
    {
        public string nomeFornecedor;

        public int Id { get; set; }
        public string Nome { get; set; }
        public float Cnpj { get; set; }

        public Fornecedor(string nomeFornecedor, float Cnpj, string Nome)
        {
            this.nomeFornecedor = nomeFornecedor;
            this.Nome = Nome;
            this.Cnpj = Cnpj;
        }
    }
}