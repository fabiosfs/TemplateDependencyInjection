using TemplateDependencyInjection.Domain.Entities;
using TemplateDependencyInjection.Domain.Interfaces;
using TemplateDependencyInjection.Infrastructure.Contexts;

namespace TemplateDependencyInjection.Infrastructure.Repositories
{
    public class ClientRepository : BaseRepository<ClientEntity, FirstDbContext>, IClientRepository
    {

        public ClientRepository(FirstDbContext context) : base(context)
        {
        }
    }
}
