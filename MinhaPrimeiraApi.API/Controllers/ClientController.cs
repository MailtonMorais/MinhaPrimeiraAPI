using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Aplication.Interface;

namespace MinhaPrimeiraApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;

        }

        [HttpPost]
        public IActionResult Gravar(ClientDto client)
        {
            if (!ModelState.IsValid)
                return BadRequest("Cliente inválido");

            _clientService.Create(client);
            return Ok("Cliente gravado com sucesso");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _clientService.GetAll();
            if (clients == null || clients.Count == 0)
                return NotFound("Nenhum cliente encontrado");
            return Ok(clients);
        }

        [HttpGet("{cpf}")]
        public IActionResult GetByCpf(string cpf)
        {
            var client = _clientService.GetByCpf(cpf);
            if (client == null)
                return NotFound("Cliente não encontrado");
            return Ok(client);

        }
        [HttpDelete]
        public IActionResult Delete(ClientDto client)
        {
            if (!ModelState.IsValid)
                return BadRequest("Cliente inválido");
            var result = _clientService.Delete(client);
            if (!result)
                return NotFound("Cliente não encontrado");
            return Ok("Cliente deletado com sucesso");
        }

        [HttpPut("{cpf}")]
        public IActionResult Update(ClientDto client, string cpf)
        {
            if (!ModelState.IsValid)
                return BadRequest("Cliente inválido");
            var existingClient = _clientService.GetByCpf(cpf);
            if (existingClient == null)
                return NotFound("Cliente não encontrado");
            _clientService.Update(client, cpf);
            return Ok("Cliente atualizado com sucesso");
        }
    }
}
