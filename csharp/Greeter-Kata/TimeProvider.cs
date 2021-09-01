using System;

namespace Greeter_Kata
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}