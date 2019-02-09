using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{
    class Program
    {
        static void Main()
        {
            string curpath = @"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task4\path";
            string targetPath = @"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task4\path1";
            string fileName = "Sample.txt";
            File.WriteAllText(Path.Combine(curpath, fileName), "Hey,i do it!");
            //by combining given path and file,it wiil create new one 
            string sourceFile = Path.Combine(curpath, fileName);//fullname of existing file
            string destFile = Path.Combine(targetPath, fileName);//fullname of destination file
            File.Copy(sourceFile, destFile);//copy existing file to another directory
            File.Delete(Path.Combine(curpath, fileName)); //delete file,which was created in first directory
        }

    }
  
}
