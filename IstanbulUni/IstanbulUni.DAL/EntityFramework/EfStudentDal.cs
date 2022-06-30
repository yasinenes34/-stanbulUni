using IstanbulUni.DAL.Abstract;
using IstanbulUni.DAL.Model;
using IstanbulUni.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.DAL.EntityFramework
{
    public class EfStudentDal : GenericRepository<Student>, IStudent
    {
        public List<Student> GetListBl()
        {
            throw new NotImplementedException();
        }

        public void StudentAddBl(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
