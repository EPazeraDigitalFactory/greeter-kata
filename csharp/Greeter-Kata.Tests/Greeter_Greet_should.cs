namespace Greeter_Kata.Tests;

public class Greeter_Greet_should
{
    [Theory]
    [InlineData("Hugh","Jass")]
    [InlineData("Mike","Rotch")]
    public void greet_user_by_name(string firstName, string lastName)
    {
        var theHour = 9;
        var timeProvider = new TimeProvider(new DateTime(2020,3,12,theHour,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User(firstName, lastName,new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Morning, {firstName} {lastName}!");
    }

    [Fact]
    public void say_good_afternoon_when_it_is_afternoon()
    {
        var theHour = 14;
        var timeProvider = new TimeProvider(new DateTime(2020,3,12,theHour,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User("Hugh","Jass",new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Afternoon, Hugh Jass!");
    }

    [Fact]
    public void say_good_evening_when_it_is_evening()
    {
        var theHour = 18;
        var timeProvider = new TimeProvider(new DateTime(2020,3,12,theHour,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User("Hugh","Jass",new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Evening, Hugh Jass!");
    }

    [Fact]
    public void say_good_night_when_it_is_after_1900()
    {
        var theHour = 19;
        var timeProvider = new TimeProvider(new DateTime(2020,3,12,theHour,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User("Hugh","Jass",new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Night, Hugh Jass!");
    }
}