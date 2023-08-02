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
        else if(hour>=12 && hour<17)
        {
            return $"Good Afternoon, {user.FirstName} {user.LastName}!";
        }
        return $"Good Evening, {user.FirstName} {user.LastName}!";
    }
}