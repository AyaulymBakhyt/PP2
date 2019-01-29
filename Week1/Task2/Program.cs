using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Student
        {
            string name, ID;
            int year = 0;
        public Student(string name,string ID)
            {
                this.name = name;
                this.ID = ID;
            }
            public void toPrint()
            {
                Console.WriteLine("Name : "+ name);
                Console.WriteLine("ID : " + ID);
            }
            public void increment()
            {
                year++;
                Console.WriteLine("Year of study now is : {0}", year);
            }
        }
        static void Main(string[] args)

        {
            Student s1 = new Student("Ayaulym", "18BD110767");
            s1.toPrint();
            s1.increment();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
