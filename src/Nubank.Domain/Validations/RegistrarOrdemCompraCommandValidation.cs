using Nubank.Domain.Commands;

namespace Nubank.Domain.Validations
{
    public class RegistrarOrdemCompraCommandValidation : OrdemVendaValidation<RegistrarOrdemCompraCommand>
    {
        public RegistrarOrdemCompraCommandValidation()
        {
            ValidarQuantidadeCompra();
        }
    }
}
