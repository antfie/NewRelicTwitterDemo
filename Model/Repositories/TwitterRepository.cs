namespace Model.Repositories
{
    using Persistance;
    using System.Collections.Generic;

    public class TwitterRepository : ITwitterRepository
    {
        readonly TweetDbContext _db = new TweetDbContext();

        public IEnumerable<Tweet> GetTweets()
        {
            return _db.Tweets;
        }
    }
}