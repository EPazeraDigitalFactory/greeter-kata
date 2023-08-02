namespace Greeter_Kata.Tests;

public class Greeter_Greet_should
{
    [Theory]
    [InlineData("Hugh","Jass")]
    public void greet_user_by_name(string firstName, string lastName)
    {

        IGreeter subject = new Greeter();
        var givenUser = new User(firstName, lastName,new DateTime(1970,1,1));
        subject.Greet(givenUser).ShouldBe("Good Morning, Hugh Jass!");
    }
}