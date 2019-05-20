public class HelloWorld
{
    public string Blah { get; private set; } = "blah";
    public string Greeting { get; set; }

    public HelloWorld()
    {
        Greeting = "Hello World!";
    }

    public string PrintGreeting()
    {
        return Greeting;
    }

}