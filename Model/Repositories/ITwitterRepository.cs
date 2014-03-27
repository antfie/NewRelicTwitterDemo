namespace Model.Repositories
{
    using System.Collections.Generic;

    public interface ITwitterRepository
    {
        IEnumerable<Tweet> GetTweets();
    }
}