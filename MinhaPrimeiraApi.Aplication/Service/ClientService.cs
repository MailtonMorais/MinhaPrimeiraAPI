using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Aplication.Interface;
using MinhaPrimeiraApi.Domain.Interface;
using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Aplication.Service
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository) 
        {
            _clientRepository = clientRepository; 
        }

        public void Create(ClientDto client)
        {
            var newClient = new Client(client.Nome, client.Cpf, client.Nascimento);

            _clientRepository.Create(newClient);

        }
        public List<ClientDto> GetAll()
        {
            var clients = _clientRepository.GetAll(); 
            var clientsDto = new List<ClientDto>();
            foreach (var client in clients)
            {
                var clientDto = new ClientDto(client.Name, client.Cpf, client.DataDeNascimento);
                clientsDto.Add(clientDto);
            }
            return clientsDto;
        }
        public ClientDto GetByCpf(string cpf)
        {
           var client = _clientRepository.GetByCpf(cpf);
            if (client == null) return null;
            var clientDto = new ClientDto(client.Name, client.Cpf, client.DataDeNascimento);
            return clientDto;
        }

        public bool Delete (ClientDto clientDto)
        {   var client = _clientRepository.GetByCpf(clientDto.Cpf);
            if (client == null) return false;
            return _clientRepository.Delete(client);
        }

        public void Update(ClientDto clientDto, string cpf)
        {
            var client = _clientRepository.GetByCpf(cpf);
            if (client == null) return;
            client.Name = clientDto.Nome;
            client.Cpf = clientDto.Cpf;
            client.DataDeNascimento = clientDto.Nascimento;
            _clientRepository.Delete(client);
            _clientRepository.Update(client);

        }
    }
}
