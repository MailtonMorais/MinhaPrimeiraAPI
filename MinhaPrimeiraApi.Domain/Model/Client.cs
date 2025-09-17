using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Domain.Model
{
    public class Client
    {
        public Client(string name, string cpf, DateTime dataDeNascimento)
        {
            Name = name;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
        }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }

    }
    
}
