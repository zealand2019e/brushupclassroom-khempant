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
        public string Season()
        {
            if (BirthMonth == 1 || BirthMonth == 12 || BirthMonth == 2)
            {
                return "Winter";
            }
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Autumn";
            }
            throw new Exception("birth is not possible");

        }
    }
}
