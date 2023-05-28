using TemplateDependencyInjection.Domain.Dtos;

namespace TemplateDependencyInjection.Domain.Interfaces
{
    public interface IClientDomain
    {
        public Task<IEnumerable<ClientDto>> GetAllAsync(CancellationToken cancel);

        public Task<ClientDto> GetByIdAsync(int id, CancellationToken cancel);

        public Task<ClientDto> CreateAsync(ClientBaseDto client, CancellationToken cancel);

        public Task<ClientDto> UpdateAsync(int id, ClientBaseDto client, CancellationToken cancel);

        public Task<ClientDto> DeleteAsync(int id, CancellationToken cancel);
    }
}
