using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Fornecedor : FornecedorRepositorio
    {
        public int Id { get; set; }
        public string NomeFornecedor { get; set; }
        public float Cnpj { get; set; }
        public string Nome { get; set; }

        public Fornecedor(string nomeFornecedor, float cnpj, string nome)
        {
            NomeFornecedor = nomeFornecedor;
            Cnpj = cnpj;
            Nome = nome;
        }
    }
}