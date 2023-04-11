using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoSimples : Produto
    {
        public ProdutoSimples(int id, long codBarras, string nome, string valor, string marca, Fornecedor fornecedor) : base(0, codBarras, nome, valor, marca, fornecedor)
        {
            this.id = id;
            this.CodBarras = codBarras;
            this.Nome = nome;
            this.Valor = valor;
            this.Marca = marca;
            this.Fornecedor = fornecedor;
        }
    }
}