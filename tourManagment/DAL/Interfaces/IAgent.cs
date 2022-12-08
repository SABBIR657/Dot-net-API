using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAgent<T, ID, RT>
    {
        RT Add(T e);
        List<T> Get();
        T Get(ID id);
        bool Edit(T e);

        bool Delete(ID id);
       
    }
}
