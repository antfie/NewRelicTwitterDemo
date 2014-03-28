namespace Model.Persistance
{
    using System.Data.Entity;

    public class TweetDbContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }

        public TweetDbContext() : base("name=TweetDb")
        {
            Database.SetInitializer(new TweetDbInitializer());
        }
    }
}