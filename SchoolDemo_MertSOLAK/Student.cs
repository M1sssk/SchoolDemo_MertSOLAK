using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo_MertSOLAK
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public Classroom Classroom { get; set; }
        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}
