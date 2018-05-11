using ECS.User.Interface;
using System;
using System.Threading;
namespace ECS.User
{
    class Yvonne : IExecutor, IPeople
    {
        public string MoveMethod { get; set; } = "腳";
        public string Name = "Yvonne";

        public void MakeCoffee()
        {
            Console.WriteLine(Name + "磨咖啡");
            Console.WriteLine(Name + "煮咖啡");
            Thread.Sleep(5000);
            Console.WriteLine("倒咖啡");
        }
        public void Turn()
        {
            Console.WriteLine(Name + "優雅地轉向");
        }
        public void Move()
        {
            Console.WriteLine(Name + "用" + MoveMethod + "優雅地移動");
        }
        public void MoveToTeaRoom()
        {
            Move();
            Turn();
            Move();
            Turn();

            Move();
            Move();
            Move();
            Turn();
            Move();
            Turn();
            Move();
        }
        public void BackToState()
        {
            Move();
            Turn();
            Move();
            Turn();
            Move();
            Move();
            Move();

            Turn();
            Move();
            Turn();
            Move();
        }
    }
}