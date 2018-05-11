using ECS.User.Interface;
using System;
using System.Threading;
namespace ECS.User
{
    class Mike : IExecutor, IPeople
    {
        public string MoveMethod { get; set; } = "腳";
        public string Name { get; set; } = "Mike";

        public void MakeCoffee()
        {
            Console.WriteLine(Name + "煮咖啡前會擦一下台子");
            Console.WriteLine(Name + "磨咖啡");
            Console.WriteLine(Name + "煮咖啡");
            Thread.Sleep(5000);
            Console.WriteLine("倒咖啡");
        }
        public void Turn()
        {
            Console.WriteLine(Name + "莽撞地轉向");
        }
        public void Move()
        {
            Console.WriteLine(Name + "用" + MoveMethod + "移動");
        }
        public void MoveToTeaRoom()
        {
            Move();
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
            Move();
        }
    }
}