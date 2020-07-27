using Reservas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


{
  public  interface IPessoa
    {
        Pessoa InserePessoa(Pessoa pessoa);
        Pessoa AlteraPessoa(Pessoa pessoa);
        void ExcluiPessoa(int codig);
        IEnumerable<Pessoa> ListarPessoa();



    }
}
