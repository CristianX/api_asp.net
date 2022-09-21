public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World!";
    }

}

// Solo se veran las funciones que se exponen aquí (En la interfaz)
public interface IHelloWorldService
{
    string GetHelloWorld();
}