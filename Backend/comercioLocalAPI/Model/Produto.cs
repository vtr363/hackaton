using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comercioLocalAPI.Model
{
    public class Produto
    {
        public int produtoId { get; set; }
        public string? nomeProduto { get; set; }
        public double valorUnitario { get; set; }
        public int quantidadeProduto { get; set; }
        public string? descricaoProduto { get; set; }
        
        public Fornecedor fornecedor { get;} = new();
        public Negociacao negociacao { get;} = new();
    }
}