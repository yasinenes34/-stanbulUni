using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T d);
        void Delete(T d);
        void Update(T d);
    }
}
