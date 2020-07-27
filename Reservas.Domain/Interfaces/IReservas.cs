using Reservas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


{
    public interface IReservas
    {
        Reserva InsereReservas(Reserva reserva);
        Reserva AlteraReservas(Reserva reserva);
        void ExcluiReservas(int codig);
        IEnumerable<Reserva> ListarResevas();

    }
}
