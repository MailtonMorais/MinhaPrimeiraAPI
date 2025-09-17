using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Domain.Model;
using MinhaPrimeiraApi.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Aplication.Interface
{
    public interface IClientService
    {
        void Create(ClientDto client);

        List<ClientDto> GetAll();
        ClientDto GetByCpf(string cpf);

    }


}
