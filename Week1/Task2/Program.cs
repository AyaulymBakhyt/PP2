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
            public string name, ID;
            public int year = 0;
            public Student( string name,string ID)
            {
                this.name = name;
                this.ID = ID;
            }
            public void toPrint()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("ID : " + ID);
                year++;
                Console.WriteLine("Year of study now is : {0}", year);
            }
        }
        static void F()
        {
            int n = int.Parse(Console.ReadLine());
            Student[] a = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string name = arr[0];
                string ID = arr[1];
                a[i] = new Student(name, ID);
            }
               for (int i = 0; i < n; i++)
                a[i].toPrint();
            }
            static void Main(string[] args)
            {
                F();
            }
        }

    }
