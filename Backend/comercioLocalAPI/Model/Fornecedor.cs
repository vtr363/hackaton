using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comercioLocalAPI.Model
{
    public class Fornecedor
    {
        public int fornecedorId { get; set; }
        public string? nomeEmpresa { get; set; }
        public string? nomeResponsavel { get; set; }
        public string? Endereço { get; set; }
        public string? cpf { get; set; }
        public string? cnpj { get; set; }
        public string? telefone { get; set; }
        public string? email { get; set; }
        public List<Negociacao> negociacoes { get; } = new();
        public int contadorVendas { get; set; }
        public List<Produto> produtos { get;} = new();


    }
}