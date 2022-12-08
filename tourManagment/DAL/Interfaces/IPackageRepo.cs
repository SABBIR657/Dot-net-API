using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPackageRepo<T,ID>
    {
        List<T> Get();
        T Get(ID id);
    }
}
