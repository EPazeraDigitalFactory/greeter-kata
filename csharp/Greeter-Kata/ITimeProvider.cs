using System;

namespace Greeter_Kata
{
    public interface ITimeProvider
    {
        DateTime Now { get; }
    }
}