using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApplication
{
    class RemoveTask
    {
        public RemoveTask(string[] args)
        {
            if(args.Length > 0)
            {
                if (args[0] == "-r")
                {
                    if (args.Length > 1)
                    {
                        try
                        {
                            string path = "ListTask.txt";
                            string[] theWholeFile = File.ReadAllLines(path);

                            if (int.TryParse(args[1], out int position))
                            {
                                if (theWholeFile.Length < position-1)
                                {
                                    Console.WriteLine("Unable to remove: index is out of bound");
                                }
                                else
                                {
                                    List<string> fileList = new List<string>();
                                    fileList.AddRange(theWholeFile);
                                    fileList.RemoveAt(int.Parse(args[1])-1);
                                    File.WriteAllLines(path, fileList.ToArray());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unable to remove: index is not a number");
                            }

                        }
                        catch
                        {
                            Console.WriteLine("File deleting doesnt work");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unable to remove: no index provided");
                    }
                }
            }
            
        }
    }
}
