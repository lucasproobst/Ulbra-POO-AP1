using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoSimples : Produto
    {
        public ProdutoSimples(long codBarras, string nome, string valor, string marca, Fornecedor fornecedor) : base(codBarras, nome, valor, marca, fornecedor)
        {
            this.CodBarras = codBarras;
            this.Nome = nome;
            this.Valor = valor;
            this.Marca = marca;
            this.Fornecedor = fornecedor;
        }
    }
}