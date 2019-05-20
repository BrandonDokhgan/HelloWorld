public class HelloWorld
{
    public string Blah { get; private set; } = "blahhhhhhhhhhhhhhhhhhhh";
    public string Greeting { get; set; } = "b;lah";

    public HelloWorld()
    {
        Greeting = "Hello World!";
    }

    public string PrintGreeting()
    {
        return Greeting;
    }

}