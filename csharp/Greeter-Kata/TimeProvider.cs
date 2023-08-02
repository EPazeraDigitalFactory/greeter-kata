public class TimeProvider : ITimeProvider
{
    public DateTime _theTime;
    public TimeProvider():this(DateTime.Now)
    {

    }
    public TimeProvider(DateTime theTime)
    {
        _theTime=theTime;
    }
    public DateTime Now => _theTime;

    public string DayPartName => throw new NotImplementedException();
}
