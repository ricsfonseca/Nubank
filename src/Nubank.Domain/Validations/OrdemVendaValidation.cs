using FluentValidation;
using Nubank.Domain.Commands;

namespace Nubank.Domain.Validations
{
    public abstract class OrdemVendaValidation<T> : AbstractValidator<T> where T : OrdemCompraCommand
    {
        protected void ValidarQuantidadeCompra()
        {
            RuleFor(c => c.QuantidadeSolicitada)
                .GreaterThan(0)
                .WithMessage("A Quantidade solicitada deve ser maior que zero");
        }

        protected void ValidarPrecoUnitario()
        {
            RuleFor(c => c.PrecoUnitario)
                .GreaterThan(0)
                .WithMessage("O Preço unitário deve ser maior que zero");
        }
    }
}
