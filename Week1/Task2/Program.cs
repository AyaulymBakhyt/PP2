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
            public Student( string name,string ID)// I will create constructor of two parameters:name and ID
            {
                this.name = name;
                this.ID = ID;
            }
            public void toPrint()//method for dislaying the name and ID of student
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("ID : " + ID);
            }
            public void incmt()//method for incrementing given year in each call
            { 
                   year++;
                Console.WriteLine("Year of study now is : " + year);
            }
        }
        
            static void Main(string[] args)
            {
           
            Student a = new Student("Ayaulym","18BD110767");//create constructor and give value for each parameter
                a.toPrint();
                a.incmt();
        }
        }

    }
