using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApplication
{
    class ListTasks
    {
        public ListTasks(string[] args)
        {
            if(args.Length > 0)
            {
                if (args[0] == "-l")
                {
                    string[] obsah = File.ReadAllLines("ListTask.txt");

                    if (obsah.Length == 0)
                    {
                        Console.WriteLine("No todos for today! :)");
                    }
                    else
                    {
                        for (int i = 0; i < obsah.Length; i++)
                        {
                            Console.WriteLine(i + 1 + "." + obsah[i]);
                        }
                    }
                }
            }
           
        }

    }
}
