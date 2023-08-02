    public interface ITimeProvider
    {
        DateTime Now { get; }
        string DayPartName{get;}
    }
