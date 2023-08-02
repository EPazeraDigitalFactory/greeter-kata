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
            if(hour>=5 && hour<12)
            {
                return "Morning";
            }
            else if(hour>=12 && hour<17)
            {
                return "Afternoon";
            }
            else if(hour>=17 && hour<19)
            {
                return "Evening";
            }
            return "Night";
        }
    }
}
