namespace Greeter_Kata.Tests;

public class Greeter_Greet_should
{
    [Fact]
    public void greet_user_by_name()
    {
        IGreeter subject = new Greeter();
        var givenUser = new User("Hugh","Jass",new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe("Good Morning, Hugh Jass!");
    }
}