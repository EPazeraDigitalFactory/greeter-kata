public class Greeter : IGreeter
{
    public string Greet(User user)
    {
        return $"Good Morning, {user.FirstName} {user.LastName}!";
    }
}