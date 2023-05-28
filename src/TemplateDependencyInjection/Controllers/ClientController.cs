using Microsoft.AspNetCore.Mvc;
using TemplateDependencyInjection.Domain.Dtos;
using TemplateDependencyInjection.Domain.Interfaces;

namespace TemplateDependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientDomain _clientDomain;
        public ClientController(IClientDomain clientDomain)
        {
            _clientDomain = clientDomain;
        }

        [HttpPost()]
        public async Task<ActionResult<ClientDto>> CreateAsync(ClientBaseDto client, CancellationToken cancel)
        {
            var newClient = await _clientDomain.CreateAsync(client, cancel);
            return Created("", newClient);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id, CancellationToken cancel)
        {
            await _clientDomain.DeleteAsync(id, cancel);
            return Ok();
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ClientDto>>> Get(CancellationToken cancel)
        {
            var clients = await _clientDomain.GetAllAsync(cancel);
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDto>> GetByIdAsync(int id, CancellationToken cancel)
        {
            var client = await _clientDomain.GetByIdAsync(id, cancel);
            return Ok(client);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ClientDto>> Update(int id, [FromBody] ClientBaseDto client, CancellationToken cancel)
        {
            var updatedClient = await _clientDomain.UpdateAsync(id, client, cancel);
            return Ok(updatedClient);
        }
    }
}