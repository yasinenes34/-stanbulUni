using IstanbulUni.BAL.Abstract;
using IstanbulUni.DAL.Abstract;
using IstanbulUni.DAL.EntityFramework;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudent _student;

        public StudentManager(IStudent student)
        {
            _student = student;
        }

        public Student GetByID(int id)
        {
            return _student.get(x=>x.ID==id);
        }

        public List<Student> GetListBl()
        {
            return _student.List();
        }

        public void StudentAddBl(Student student)
        {
            _student.Insert(student);
        }

        public bool StudentRemoveBl(Student student)
        {
            var _studentInfo = _student.get(t => t.ID == student.ID);
            if (_studentInfo != null)
            {
                _student.Delete(student);
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
