using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


{
    public interface IItem
    {
        IItem InsereItem(IItem item);
        IItem AlteraItem(IItem item);
        void ExcluiItme(int codig);
        IEnumerable<IItem> ListarItens();

    }
}
