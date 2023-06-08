namespace {{RootNamespace}};

[ExcludeFromCodeCoverage]
public class Program
{
    public static void Main(string[] args)
    {
        ServiceBootstrapper bootstrapper = new (args);
        bootstrapper.BootstrapAndRun();
    }
}