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

            Get["/", true] = async (parameters, ct) => Response.AsJson(domain.GetLatestTweets());

            Get["/users/{userName}/tweets", true] = async (parameters, ct) =>
            {
                string userName = parameters.userName;
                NewRelic.Api.Agent.NewRelic.AddCustomParameter("UserName", userName);

                return Response.AsJson(domain.GetLatestTweets(userName));
            };
        }
    }
}