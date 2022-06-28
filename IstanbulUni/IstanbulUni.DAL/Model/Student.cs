using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.DAL.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentNo { get; set; }
        public string UniversityName { get; set; }
        public decimal examScore { get; set; }
    }
}
