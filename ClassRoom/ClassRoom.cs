using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private string className;
        private List<Student> students;
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        private DateTime semesterStart;
        public DateTime SemesterStart
        {
            get { return semesterStart; }
            set { semesterStart = value; }
        }
        public ClassRoom()
        {
            students = new List<Student>();
        }

        public int NoOfStudentsWithBirthMonth(int month)
        {
            int[] months = new int[12];
            foreach (var item in Students)
            {
                months[item.BirthMonth]++;
            }
            return months[month];
        }

    }
}
