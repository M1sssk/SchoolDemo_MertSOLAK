using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo_MertSOLAK
{
    public class Instructor
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return Name + " " + LastName;
        }
        public Classroom Classroom { get; set; }
    }
}
