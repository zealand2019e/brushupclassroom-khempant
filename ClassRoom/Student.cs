using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string name;
        private int birth_day;
        private int birth_month;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int BirthDay
        {
            get { return birth_day; }
            set { birth_day = value; }
        }
        public int BirthMonth
        {
            get { return birth_month; }
            set { birth_month = value; }
        }
        public Student(int bday, int bmonth, string name)
        {
            Name = name;
            BirthDay = bday;
            BirthMonth = bmonth;
        }
        
    }
}
