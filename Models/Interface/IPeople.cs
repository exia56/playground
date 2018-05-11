namespace ECS.User.Interface
{
    interface IPeople
    {
        string MoveMethod { get; set; }
        string Name { get; set; }

        void Move();
        void Turn();
    }
}