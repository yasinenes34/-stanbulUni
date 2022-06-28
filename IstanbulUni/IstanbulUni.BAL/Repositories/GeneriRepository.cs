using IstanbulUni.BAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Repositories
{
    internal class GeneriRepository<T> : IRepository<T> where T : class
    {
        public void Delete(T d)
        {
            throw new NotImplementedException();
        }

        public void Insert(T d)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T d)
        {
            throw new NotImplementedException();
        }
    }
}
