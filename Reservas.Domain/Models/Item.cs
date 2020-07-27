using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Entities
{
   public class Item
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double valor_item { get; set; }
        public Byte status { get; set; }
    }
}
