using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class Complex
    {
        public int real;
        public int imaginary;
        public Complex() { }
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Complex c = new Complex(a, b);
            Console.WriteLine(c);
            FileStream fs = new FileStream("complexnumber.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xm = new XmlSerializer(typeof(Complex));
            xm.Serialize(fs, c);
            fs.Close();
            FileStream fs1 = new FileStream("complexnumber.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex s = xs.Deserialize(fs1) as Complex;
            Console.WriteLine(s);
            fs1.Close();

        }
      
    }
}
