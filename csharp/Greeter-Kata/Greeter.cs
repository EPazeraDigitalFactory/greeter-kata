public class Greeter : IGreeter
{
    private ITimeProvider _timeProvider;
    public Greeter(ITimeProvider timeProvider)
    {
        _timeProvider=timeProvider;
    }
    public string Greet(User user)
    {
        return $"Good {_timeProvider.DayPartName}, {user.FirstName} {user.LastName}!";
    }
}