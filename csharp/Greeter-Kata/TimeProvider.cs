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
    const string Morning="Morning";
    const string Afternoon="Afternoon";
    const string Evening="Evening";
    const string Night="Night";
    static readonly IReadOnlyList<string> DatePartNames = new List<string>
    {
        Night,
        Night,
        Night,
        Night,
        Night,
        Morning,
        Morning,
        Morning,
        Morning,
        Morning,
        Morning,
        Morning,
        Afternoon,
        Afternoon,
        Afternoon,
        Afternoon,
        Afternoon,
        Evening,
        Evening,
        Night,
        Night,
        Night,
        Night,
        Night
    };

    public string DayPartName
    {
        get
        {
            return DatePartNames[_theTime.Hour];
        }
    }
}
