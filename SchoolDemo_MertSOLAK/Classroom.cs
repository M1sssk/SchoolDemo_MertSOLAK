using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo_MertSOLAK
{
    public class Classroom
    {
        public Classroom()
        {
            Students = new List<Student>();
        }
        public int ClassNo { get; set; }
        public string Letter { get; set; }
        public string Department { get; set; }

        // 10-FM-C
        public string ClassName { get => ClassNo + "-" + Department + "-" + Letter; }

        private List<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudent() => Students;

        public int StudentCount { get => Students.Count(); }

        public Instructor MasterInstructor { get; set; }
        public void SetMainInstructor(Instructor ınstructor)
        {
            MasterInstructor = ınstructor;
        }
    }
}
