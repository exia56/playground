using System;
using System.Threading;

namespace ECS
{
    class Program
    {
        static void Main(string[] args)
        {
            var executor = "Mike";
            makeCoffee(executor);
        }

        static void makeCoffee(string executor)
        {
            Console.WriteLine(executor + "去泡咖啡");
            Console.WriteLine("站起來");
            //"路徑不同"
            if (executor == "Mike")
            {
                Console.WriteLine("走路");
                Console.WriteLine("走路");
                Console.WriteLine("轉彎");
            }
            else if (executor == "Yvonne")
            {
                Console.WriteLine("走路");
                Console.WriteLine("轉彎");
                Console.WriteLine("走路");
                Console.WriteLine("轉彎");
            }
            else throw new Exception("不是Mike或Yvonne去泡咖啡，路徑不對啊");
            Console.WriteLine("走路");
            Console.WriteLine("走路");
            Console.WriteLine("走路");
            Console.WriteLine("轉彎");
            Console.WriteLine("走路");
            Console.WriteLine("轉彎");
            Console.WriteLine("走路");
            Console.WriteLine("磨咖啡");
            Console.WriteLine("泡咖啡");
            Console.WriteLine("手冲5秒鐘");
            Thread.Sleep(5000);
            Console.WriteLine("倒咖啡");
            Console.WriteLine("走路");
            Console.WriteLine("轉彎");
            Console.WriteLine("走路");
            Console.WriteLine("轉彎");
            Console.WriteLine("走路");
            Console.WriteLine("走路");
            Console.WriteLine("走路");
            if (executor == "Mike")
            {
                Console.WriteLine("轉彎");
                Console.WriteLine("走路");
                Console.WriteLine("走路");
            }
            else if (executor == "Yvonne")
            {
                Console.WriteLine("轉彎");
                Console.WriteLine("走路");
                Console.WriteLine("轉彎");
                Console.WriteLine("走路");
            }
            Console.WriteLine("坐下");
        }
    }
}
