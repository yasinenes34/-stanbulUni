using IstanbulUni.DAL.Abstract;
using IstanbulUni.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        IstanbulUniContext db = new IstanbulUniContext();
        DbSet<T> obj;
        public GenericRepository()
        {
            obj=db.Set<T>();
        }
        public void Delete(T d)
        {
            var deletedEntity=db.Entry(d);
            deletedEntity.State=EntityState.Deleted;
           // obj.Remove(d);
            db.SaveChanges();
        }

        public T get(Expression<Func<T, bool>> filiter)
        {
            return obj.SingleOrDefault(filiter);
        }

        public void Insert(T d)
        {
            var addedEntity=db.Entry(d);
            addedEntity.State= EntityState.Added;       
            //obj.Add(d);
            db.SaveChanges();
        }

        public List<T> List()
        {
           return obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filiter)
        {
            throw new NotImplementedException();
        }

        public void Update(T d)
        {
            var updatedEntity=db.Entry(d);
            updatedEntity.State= EntityState.Modified;  
            db.SaveChanges();
        }
    }

   
}
