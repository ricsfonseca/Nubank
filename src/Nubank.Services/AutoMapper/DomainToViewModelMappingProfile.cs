using AutoMapper;
using Nubank.Application.ViewModels.Clientes;
using Nubank.Domain.Models.Clientes;

namespace Nubank.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
