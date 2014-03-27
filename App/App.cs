namespace App
{
    using Domain;
    using Model.Repositories;
    using Nancy;

    public class App : NancyModule
    {
        public App()
        {
            var domain = new Twitter(new TwitterRepository());

            Get["/"] = parameters => Response.AsJson(domain.GetLatestTweets());

            Get["/users/{userName}/tweets"] = _ =>
            {
                NewRelic.Api.Agent.NewRelic.AddCustomParameter("UserName", _.userName);

                return Response.AsJson(domain.GetLatestTweets((string)_.userName));
            };
        }
    }
}