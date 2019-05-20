public class HelloWorld
{
    public string Greeting {get;set;}

    public HelloWorld()
    {
        Greeting = "Hello World!";
    }

    public string PrintGreeting()
    {
        return Greeting;
    }

}