using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class MyThread
    {
        Thread threadField;
        public string name;
        public MyThread(string _name)
        {
            name = _name;
        }
        public void StartThread()
        {
            threadField = new Thread(Output);
            threadField.Start();
        }
        public void Output()
        {
            int i = 0;
            while(i!=4)
            {
                i++;
                Console.WriteLine((name + " "  + "displays" + " " + i).ToString());
            }
            if(i == 4)
            Console.WriteLine("End of" + " " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread thread1 = new MyThread("Thread 1");
            MyThread thread2 = new MyThread("Thread 2");
            MyThread thread3 = new MyThread("Thread 3");
            
            thread1.StartThread();
            thread2.StartThread();
            thread3.StartThread();
        }
    }
}
