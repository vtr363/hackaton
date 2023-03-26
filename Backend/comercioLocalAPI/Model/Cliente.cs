using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comercioLocalAPI.Model
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string? nomeCliente { get; set; }
        public string? responsavelCliente { get; set; }
        public string? Endereço { get; set; }
        public string? cpf { get; set; }
        public string? cnpj { get; set; }
        public string? telefone { get; set; }
        public List<string> email { get; } = new();
        public List<Negociacao> negociacoes { get; } = new();

    }
}