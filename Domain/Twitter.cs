namespace Domain
{
    using Model;
    using Model.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class Twitter
    {
        private const int NumberOfLatestTweetsToReturn = 10;

        private readonly ITwitterRepository _repository;

        public Twitter(ITwitterRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Tweet> GetLatestTweets()
        {
            var r =  _repository.GetTweets()
                              .OrderByDescending(t => t.Timestamp)
                              .Take(NumberOfLatestTweetsToReturn);

            return r;
        }

        public IEnumerable<Tweet> GetLatestTweets(string userName)
        {
            return _repository.GetTweets()
                              .Where(t => t.User == userName)
                              .OrderByDescending(t => t.Timestamp)
                              .Take(NumberOfLatestTweetsToReturn);
        }
    }
}