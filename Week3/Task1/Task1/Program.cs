using System;
using System.IO;

namespace Farr
{
    class Program
    {
        class FarManager
        {
            public int cursor;
            public string path;
            public int sz;
            public FileSystemInfo currentfs = null;
            DirectoryInfo dir = null;
            public FarManager()
            {
                cursor = 0;
            }
            public FarManager(string path)
            {
                this.path = path;
                cursor = 0;
                dir = new DirectoryInfo(path);
                sz = dir.GetFileSystemInfos().Length;//the amount of all elements in dir
            }
            public void Color(FileSystemInfo f, int index)
            {
                if (cursor == index) //if the cursor equals to index of the element FSI f,this line will be painted in the specified color
                {
                    currentfs = f;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (f.GetType() == typeof(DirectoryInfo)) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//directory is yellow
                }
                else if (f.GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;//file is white
                }
               
            }
            public void Show()//needs for printing all elements of FSI,in given directory 
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                dir = new DirectoryInfo(path);
                int ind = 1;
                FileSystemInfo[] fs = dir.GetFileSystemInfos();//creates array from elements of dir
                for (int i = 0; i < fs.Length; i++)
                {
                    Color(fs[i], i);//to hightlight type of fs

                    Console.WriteLine(ind + "." + " " + fs[i]);
                    ind++;
                }
            }
            public void Up() //moves the cursor up
            {
                cursor--;
                if (cursor == -1) //if we press the cursor above the first line, it goes to the last
                {
                    cursor = sz - 1;
                }
            }
            public void Down()//moves the cursor down
            {
                cursor++;
                if (cursor == sz)//if we press the cursor under the last line, it goes to the first
                {
                    cursor = 0;
                }

            }
            public void Start()
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();//describes the console key that was pressed
                while (true)
                {
                    Show();
                    keyinfo = Console.ReadKey();
                    FileInfo f1 = new FileInfo(currentfs.FullName);
                    if (keyinfo.Key == ConsoleKey.UpArrow)//this key allows us to press line  up
                    {
                        Up();
                    }
                    else if (keyinfo.Key == ConsoleKey.DownArrow)//this key allows us to press line  down
                    {
                        Down();
                    }
                    if (keyinfo.Key == ConsoleKey.Enter)//this key allows us:
                        //if it is directory to open it
                        //if it is file to read then open  all consistents
                    {
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            cursor = 0;
                            path = currentfs.FullName;
                        }

                        if (currentfs.GetType() == typeof(FileInfo))
                        {
                            cursor = 0;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            using (StreamReader sr = new StreamReader(currentfs.FullName))//for reading text
                            {
                                Console.WriteLine(sr.ReadToEnd());//displaying in console
                            }
                            Console.ReadKey();

                        }
                    }
                    if (keyinfo.Key == ConsoleKey.Delete)//this key let us delete directories and files
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                                Directory.Delete(currentfs.FullName);
                        }
                        else 
                        {
                            File.Delete(currentfs.FullName);
                        }
                    }
                    if (keyinfo.Key == ConsoleKey.F5)//key needs for renaming
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            Console.Clear();
                            string s = Console.ReadLine();// i will enter new  name for  folder
                            string Name = currentfs.Name;
                            string fName = currentfs.FullName;//path to directory
                            string newpath = " ";//for saving new path
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                newpath += fName[i];
                            }
                            newpath = newpath + s;//new path to changed name
                            Directory.Move(fName, newpath);//the process of renaming
                        }
                        else
                        {
                            Console.Clear();
                            string s = Console.ReadLine();
                            string Name = currentfs.Name;
                            string fName = currentfs.FullName;
                            string newpath = " ";
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                newpath += fName[i];
                            }
                            newpath = newpath + s;
                            File.Move(fName, newpath);
                        }

                    }
                    if (keyinfo.Key == ConsoleKey.Backspace)//get out from current directory 
                    {
                        cursor = 0;
                        if (dir.Parent != null)
                        {
                            path = dir.Parent.FullName;//retrieves the parent directory of the specified path
                        }
                        else
                        {
                            break;
                        }
                    }

                }

            }
            static void Main(string[] args)
            {

                string path = @"C:\Users\Raelisten\Documents\PP2\PP2\Week3\Task1\hardcor";

                FarManager far = new FarManager(path);
                far.Start();
            }
        }
    }
}
