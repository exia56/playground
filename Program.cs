using System;
using System.Threading;

using ECS.User.Interface;
using ECS.User;

namespace ECS.E303
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutor executor = new Yvonne();
            makeCoffee(executor);
        }

        static void makeCoffee(IExecutor executor)
        {
            Console.WriteLine(executor + "去泡咖啡");
            Console.WriteLine("站起來");
            //"路徑不同"
            executor.MoveToTeaRoom();
            executor.MakeCoffee();
            executor.BackToState();
            Console.WriteLine("坐下");
        }
    }
}
