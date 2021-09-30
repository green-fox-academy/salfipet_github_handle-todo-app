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
            if(args.Length > 0)
            {
                if (args[0] == "-a")
                {
                    if (args.Length > 1)
                    {
                        try
                        {
                            string path = "ListTask.txt";
                            for (int i = 1; i < args.Length; i++)
                            {
                                File.AppendAllText(path, "[ ]" + args[i] + "\r\n");
                            }
                            

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
}
