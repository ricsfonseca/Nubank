using System;
using Nubank.Domain.Validations;

namespace Nubank.Domain.Commands
{
    public class RegistrarOrdemCompraCommand : OrdemCompraCommand
    {
        public RegistrarOrdemCompraCommand(Guid clienteId, Guid produtoId, int quantidadeSolicitada)
        {
            Id = Guid.NewGuid();
            ClienteId = clienteId;
            ProdutoId = produtoId;
            QuantidadeSolicitada = quantidadeSolicitada;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegistrarOrdemCompraCommandValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
