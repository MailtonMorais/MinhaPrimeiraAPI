using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Infrastructure.DataBase
{
    public class BancoDeDados : IBancoDeDados
    {

        public List<Client> DbClient = new List<Client>();

        public List<Product> DbProduct = new List<Product>();


        public void CreateClient(Client client)
        {
            DbClient.Add(client);
        }

        public List<Client> GetAllClient()
        {
            return DbClient;
        }
        public Client GetByCpfClient(string cpf)
        {
            return DbClient.FirstOrDefault(c => c.Cpf == cpf);

        }

        public bool DeleteClient(Client client)
        {
            var qtdIncial = DbClient.Count;

            DbClient.Remove(client);

            if (qtdIncial > DbClient.Count)
                return true;
            return false;

        }
        public void UpdateClient(Client client)
        {
            CreateClient(client);
        }

        //Product
        public void CreateProduct(Product product)
        {
            DbProduct.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return DbProduct;
        }

        public Product GetByIdProduct(int id)
        {
            return DbProduct.FirstOrDefault(p => p.Id == id);

        }
    }
}
