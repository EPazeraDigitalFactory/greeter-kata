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

    public string DayPartName
    {
        get
        {
            var hour = _theTime.Hour;
            if(hour<12)
            {
                return "Morning";
            }
            else if(hour>=12 && hour<17)
            {
                return "Afternoon";
            }
            return "Evening";
        }
    }
}
