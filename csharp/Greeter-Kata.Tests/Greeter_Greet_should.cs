namespace Greeter_Kata.Tests;

public class Greeter_Greet_should
{
    [Theory]
    [InlineData("Hugh","Jass")]
    [InlineData("Mike","Rotch")]
    public void greet_user_by_name(string firstName, string lastName)
    {
        var timeProvider = new FakeTimeProvider(new DateTime(2020,3,12,9,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User(firstName, lastName,new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Morning, {firstName} {lastName}!");
    }

    [Fact]
    public void say_good_afternoon_when_it_is_afternoon()
    {
        var timeProvider = new FakeTimeProvider(new DateTime(2020,3,12,14,0,0));
        IGreeter subject = new Greeter(timeProvider);
        var givenUser = new User("Hugh","Jass",new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe($"Good Afternoon, Hugh Jass!");
    }
}