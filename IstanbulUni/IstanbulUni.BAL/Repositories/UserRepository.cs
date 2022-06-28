using IstanbulUni.BAL.Abstract;
using IstanbulUni.DAL.Context;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Repositories
{
    internal class UserRepository : IRegisterBal
    {
        IstanbulUniContext c = new IstanbulUniContext();
        DbSet<User> user;
        public void Delete(User d)
        {
            user.Remove(d);
            c.SaveChanges();
        }

        public void Insert(User d)
        {
            user.Add(d);
            c.SaveChanges();
        }

        public List<User> List()
        {
            return user.ToList();
        }

        public void Update(User d)
        {
            c.SaveChanges();
        }
    }
}
