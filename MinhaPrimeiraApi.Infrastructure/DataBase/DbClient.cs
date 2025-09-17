using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Infrastructure.DataBase
{
    public class DbClient: IDb
    {
        public List<Client> Db = new List<Client>();
        //CRUD - Create, Read, Update, Delete
        public void Create(Client client)
        {
            Db.Add(client);
        }

        public List<Client> GetAll()
        {
            return Db;
        }
        public Client GetByCpf(string cpf)
        {
            return Db.FirstOrDefault(c => c.Cpf == cpf);

        }
    }
}
