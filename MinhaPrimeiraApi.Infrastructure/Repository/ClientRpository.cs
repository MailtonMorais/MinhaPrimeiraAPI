using MinhaPrimeiraApi.Domain.Interface;
using MinhaPrimeiraApi.Domain.Model;
using MinhaPrimeiraApi.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Infrastructure.Repository
{
    public class ClientRpository : IClientRepository
    {
        private readonly IDb _db;
        public ClientRpository(IDb db)  
        {
           _db = db;
        }
        public void Create(Client client)
            => _db.Create(client);
        public List<Client> GetAll()
            => _db.GetAll();
        public Client GetByCpf(string cpf)
            => _db.GetByCpf(cpf);


    }
}
