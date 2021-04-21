using System;
using Nubank.Domain.Core.Commands;

namespace Nubank.Domain.Commands
{
    public abstract class OrdemCompraCommand : Command
    {
        public Guid Id { get; protected set; }
        public DateTime DataOperacao { get; protected set; }
        public Guid ProdutoId { get; protected set; }
        public Guid ClienteId { get; protected set; }
        public int QuantidadeSolicitada { get; protected set; }
        public decimal ValorOperacao { get; protected set; }
        public decimal PrecoUnitario { get; protected set; }
    }
}
