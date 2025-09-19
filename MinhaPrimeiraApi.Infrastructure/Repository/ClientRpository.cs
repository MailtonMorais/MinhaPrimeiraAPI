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
        private readonly IBancoDeDados _db;
        public ClientRpository(IBancoDeDados db)  
        {
           _db = db;
        }
        public void Create(Client client)
            => _db.CreateClient(client);
        public List<Client> GetAll()
            => _db.GetAllClient();
        public Client GetByCpf(string cpf)
            => _db.GetByCpfClient(cpf);
        public bool Delete (Client client)
            => _db.DeleteClient(client);
        public void Update(Client client)
            => _db.UpdateClient(client);


    }
}
