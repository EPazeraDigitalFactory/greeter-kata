public class Greeter : IGreeter
{
    private ITimeProvider _timeProvider;
    public Greeter(ITimeProvider timeProvider)
    {
        _timeProvider=timeProvider;
    }
    public string Greet(User user)
    {
        var rightNow = _timeProvider.Now;
        var hour = rightNow.Hour;
        if(hour<12)
        {
            return $"Good Morning, {user.FirstName} {user.LastName}!";
        }
        else
        {
            return $"Good Afternoon, {user.FirstName} {user.LastName}!";
        }
    }
}