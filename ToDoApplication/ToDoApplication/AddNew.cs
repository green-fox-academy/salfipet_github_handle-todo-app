using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApplication
{
    class AddNew
    {
        public AddNew(string[] args)
        {
            if (args[0] == "-a")
            {
                if (args.Length > 1)
                {
                    try
                    {
                        string path = "ListTask.txt";
                        File.AppendAllText(path,  "[ ]" + args[1] +"\r\n" );

                    }
                    catch
                    {
                        Console.WriteLine("File writing doesnt work");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                   
                }
               
               
                
            }
            
        }
    }
}
