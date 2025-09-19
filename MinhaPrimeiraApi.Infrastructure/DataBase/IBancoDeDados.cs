using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Infrastructure.DataBase
{
    public interface IBancoDeDados
    {
        void CreateClient(Client client);
        List<Client> GetAllClient();
        Client GetByCpfClient(string cpf);
        bool DeleteClient(Client client);
        void UpdateClient(Client client);

        //Product
        void CreateProduct(Product product);
        List<Product> GetAllProducts();
        Product GetByIdProduct(int id);

    }

}
