using Nexus.Framework.Web;

namespace {{RootNamespace}};

public class ServiceBootstrapper : NexusServiceBootstrapper
{
    public ServiceBootstrapper(string[] args) : base(args)
    {
    }

   
    protected override void ConfigureMiddleware()
    {
        base.ConfigureMiddleware();
        App.MapControllers();
    }
}