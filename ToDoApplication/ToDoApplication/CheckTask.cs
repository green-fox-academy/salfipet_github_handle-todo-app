using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApplication
{
    class CheckTask
    {
        public CheckTask(string[] args)
        {
            if (args[0] == "-c")
            {
                if (args.Length > 1)
                {
                    string path = "ListTask.txt";
                    string[] theWholeFile = File.ReadAllLines(path);

                    if (int.TryParse(args[1], out int position))
                    {
                        if (theWholeFile.Length < position)
                        {
                            Console.WriteLine("Unable to check: index is out of bound");
                        }
                        else
                        {
                            List<string> fileList = new List<string>();
                            fileList.AddRange(theWholeFile);
                            fileList[int.Parse(args[1]) - 1] = fileList[int.Parse(args[1]) - 1].Insert(1, "X");
                            fileList[int.Parse(args[1]) - 1] = fileList[int.Parse(args[1]) - 1].Remove(2, 1);
                            File.WriteAllLines(path, fileList.ToArray());
                        }

                    }
                    else
                    {
                        Console.WriteLine("Unable to check: index is not a number");
                    }
                     
                }
                else
                {
                    Console.WriteLine("Unable to check: no index provided");
                }
            }
        }
    }
}
