using Nancy;

namespace NancyKickStart.Web.Configuration
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {

        protected override System.Type RootPathProvider
        {
            get
            {
                return typeof (Nancy.Hosting.Aspnet.AspNetRootSourceProvider);
            }
        }
    }
}