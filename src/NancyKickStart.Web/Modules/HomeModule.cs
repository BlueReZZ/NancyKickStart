using Nancy;

namespace NancyKickStart.Web.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["home.cshtml"];
        }
    }
}