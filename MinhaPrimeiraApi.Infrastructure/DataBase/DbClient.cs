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
        public List<Product> DbProduct = new List<Product>();


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

        public bool Delete(Client client)
        {
            var qtdIncial = Db.Count;

            Db.Remove(client);

            if (qtdIncial > Db.Count)
                return true;
            return false;

        }

        public void Update(Client client)
        { 
          Create(client);
        }


    }
}
