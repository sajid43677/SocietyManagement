using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.interfaces
{
    public interface IRepo<Type, ID, Ret>
    {
        Ret Create(Type obj);

        List<Type> Read();

        Type Read(ID id);

        Ret Update(Type obj);

        bool Delete(ID id);
    }
}
