using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Domain.Model;
using MinhaPrimeiraApi.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        bool Delete(ClientDto client);
        void Update(ClientDto client, string cpf);



    }


}
