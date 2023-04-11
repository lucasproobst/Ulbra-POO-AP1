using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public abstract class Produto
    {
        public int id { get; set; }
        public long CodBarras { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Marca { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Produto(int id, long codBarras, string nome, string valor, string marca, Fornecedor fornecedor)
        {
            this.CodBarras = codBarras;
            this.Nome = nome;
            this.Valor = valor;
            this.Marca = marca;
            this.Fornecedor = fornecedor;
        }

        public static implicit operator List<object>(Produto v)
        {
            throw new NotImplementedException();
        }
    }
}