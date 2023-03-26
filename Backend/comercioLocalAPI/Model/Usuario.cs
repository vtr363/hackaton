using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comercioLocalAPI.Model
{
    public abstract class Usuario
    {
        public Guid usuarioId { get; private set; }
        public string? nomeEmpresa { get; private set; }
        public string? nomeResponsavel { get; private set; }
        public string? endereço { get; private set; }
        public string? cpf { get; private set; }
        public string? cnpj { get; private set; }
        public string? telefone { get; private set; }
        public List<string> email { get; } = new();
        public List<Negociacao> negociacoes { get; } = new();
    }
}