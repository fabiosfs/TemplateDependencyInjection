using AutoMapper;
using TemplateDependencyInjection.Domain.Dtos;
using TemplateDependencyInjection.Domain.Entities;

namespace TemplateDependencyInjection.Domain.Mapper
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            CreateMap<ClientDto, ClientEntity>()
                    .ReverseMap();

            CreateMap<ClientBaseDto, ClientEntity>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<ClientEntity, ClientBaseDto>();
        }
    }
}
