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
            }
            public void incmt()
            { 
                   year++;
                Console.WriteLine("Year of study now is : " + year);
            }
        }
        
            static void Main(string[] args)
            {
           
            Student a = new Student("Ayaulym","18BD110767");
                a.toPrint();
                a.incmt();
        }
        }

    }
