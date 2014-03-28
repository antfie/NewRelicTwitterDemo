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

            Get["/"] = _ => Response.AsJson(domain.GetLatestTweets());

            Get["/users/{userName}/tweets"] = _ =>
            {
                string userName = _.userName;

                NewRelic.Api.Agent.NewRelic.AddCustomParameter("UserName", userName);

                return Response.AsJson(domain.GetLatestTweets(userName));
            };
        }
    }
}