using System;
using System.IO;

namespace ToDoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run");
            string[] newArr = args;

            while (newArr.Length == 0 || newArr[0] != "exit")
            {
                PrintUsage printAll = new PrintUsage(newArr);
                ListTasks listTask = new ListTasks(newArr);
                AddNew addTask = new AddNew(newArr);
                RemoveTask removeSomething = new RemoveTask(newArr);
                CheckTask doneTask = new CheckTask(newArr);

                string newInput = Console.ReadLine();
                string[] anotherStrings = newInput.Split(' ',2);
                
                if(anotherStrings.Length > 1)
                {
                    if (anotherStrings[1].Contains(','))
                    {
                        string[] anotherStrings2 = anotherStrings[1].Split(',');
                        string[] almostNewArr = new string[anotherStrings2.Length+1];
                        for (int i = 0; i < anotherStrings2.Length+1; i++)
                        {
                            if(i == 0)
                            {
                                almostNewArr[0] = anotherStrings[0];
                            }
                            else
                            {
                                almostNewArr[i] = anotherStrings2[i-1];
                            }
                        }
                        newArr = almostNewArr;
                    }
                    else
                    {
                        newArr = newInput.Split(' ', 2);
                    }
                }
                else
                {
                    newArr = newInput.Split(' ', 2);
                }
            }

            Console.WriteLine("end");
            Console.ReadLine();

        }
    }
}
