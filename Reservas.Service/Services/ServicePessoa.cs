using Reservas.Domain;
using Reservas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Reservas.Service.Services
{
    public class ServicePessoa : IPessoa

    {
        public Pessoa AlteraPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void ExcluiPessoa(int codig)
        {
            throw new NotImplementedException();
        }

        public Pessoa InserePessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> ListarPessoa()
        {
            return null;
        }
    }
}