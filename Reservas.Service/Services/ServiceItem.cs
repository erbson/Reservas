using Reservas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Service.Services
{
    public class ServiceItem : IItem
    {
        public IItem AlteraItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void ExcluiItme(int codig)
        {
            throw new NotImplementedException();
        }

        public IItem InsereItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> ListarItens()
        {
            throw new NotImplementedException();
        }
    }
}
