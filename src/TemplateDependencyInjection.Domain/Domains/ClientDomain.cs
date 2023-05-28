using AutoMapper;
using TemplateDependencyInjection.Domain.Dtos;
using TemplateDependencyInjection.Domain.Entities;
using TemplateDependencyInjection.Domain.Interfaces;

namespace TemplateDependencyInjection.Domain.Domains
{
    public class ClientDomain : IClientDomain
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientDomain(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClientDto> CreateAsync(ClientBaseDto clientDto, CancellationToken cancel)
        {
            var clientEntity = _mapper.Map<ClientEntity>(clientDto);
            clientEntity = await _clientRepository.CreateAsync(clientEntity, cancel);
            return _mapper.Map<ClientDto>(clientEntity);
        }

        public async Task<ClientDto> DeleteAsync(int id, CancellationToken cancel)
        {
            var client = await _clientRepository.DeleteAsync(id, cancel);
            return _mapper.Map<ClientDto>(client);
        }

        public async Task<IEnumerable<ClientDto>> GetAllAsync(CancellationToken cancel)
        {
            var clients = await _clientRepository.GetAllAsync(cancel);
            return _mapper.Map<IEnumerable<ClientDto>>(clients);
        }

        public async Task<ClientDto> GetByIdAsync(int id, CancellationToken cancel)
        {
            var client = await _clientRepository.GetByIdAsync(id, cancel);
            return _mapper.Map<ClientDto>(client);
        }

        public async Task<ClientDto> UpdateAsync(int id, ClientBaseDto clientDto, CancellationToken cancel)
        {
            var clientEntity = _mapper.Map<ClientEntity>(clientDto);
            clientEntity.Id = id;
            clientEntity = await _clientRepository.UpdateAsync(clientEntity, cancel);
            return _mapper.Map<ClientDto>(clientEntity);
        }
    }
}
