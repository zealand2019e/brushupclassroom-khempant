using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom myClass = new ClassRoom();
            myClass.ClassName = "3Q";
            myClass.Students.Add(new Student(3, 9, "Popular"));
            myClass.Students.Add(new Student(29, 1, "Khem"));
            myClass.Students.Add(new Student(12, 6, "Ganga"));

            Console.WriteLine(myClass.ClassName);
            Console.WriteLine(myClass.SemesterStart.ToString());

            foreach(var item in myClass.Students)
            {
                Console.WriteLine(item.Name + " " + item.BirthDay + " " + item.BirthMonth);
                    
            }
            Console.WriteLine(myClass.NoOfStudentsWithBirthMonth(1).ToString());
            Console.ReadLine();
        }
    }
}
