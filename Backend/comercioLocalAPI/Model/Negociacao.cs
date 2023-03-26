using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comercioLocalAPI.Model
{
    public class Negociacao
    {
        public int negociacaoId { get; set; }
        public int status { get; set; }
        public DateTime dataNegociacao { get; set; }
        public List<Produto> produtos { get;} = new();
        
        public Fornecedor fornecedor { get;} = new();
        public Cliente cliente { get;} = new();
    }
}