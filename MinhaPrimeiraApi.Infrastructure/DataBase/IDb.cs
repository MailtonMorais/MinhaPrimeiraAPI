using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Infrastructure.DataBase
{
    public interface IDb
    {
        void Create(Client client);
        List<Client> GetAll();
        Client GetByCpf(string cpf);
        bool Delete(Client client);
        void Update(Client client);


    }


}
