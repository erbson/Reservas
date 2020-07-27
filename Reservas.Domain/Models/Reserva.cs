using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Entities
{
   public  class Reserva
    {
        public int codigo { get; set; }
        public string pessoa { get; set; }
        public double valor_reserva { get; set; }
        public string item_reservado { get; set; }
        public string data_reserva { get; set; }
    }
}
