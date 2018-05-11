namespace ECS.User.Interface
{
    interface IPeople
    {
        string MoveMethod{get;set;}
        
        void Move();
        void Turn();
    }
}