using System;
using System.IO;

namespace ToDoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUsage printAll = new PrintUsage(args);
            ListTasks listTask = new ListTasks(args);
            AddNew addTask = new AddNew(args);
            RemoveTask removeSomething = new RemoveTask(args);
            CheckTask doneTask = new CheckTask(args);

            Console.ReadLine();
        }
    }
}
