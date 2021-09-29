using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class PrintUsage
    {
        public PrintUsage(string[] args)
        {
            if (args.Length == 0)
            {
                for (int i = 0; i < TextPrint().Length ; i++)
                {
                    Console.WriteLine(TextPrint()[i]);
                }
                Console.ReadLine();
            }
            
           
            //Console.ReadLine();
        }
        public string[] TextPrint()
        {
            string[] textConsole = { "Command line arguments:", "    -l   Lists all the tasks", "    -a   Adds a new task", "    -r   Removes an task", "    -c   Completes an task" };
            return textConsole;

        }
    }
}
