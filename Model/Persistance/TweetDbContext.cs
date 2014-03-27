namespace Model.Persistance
{
    using System.Data.Entity;

    public class TweetDbContext : DbContext
    {
        public TweetDbContext() : base("name=TweetDb")
        {
        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}