namespace Model.Persistance
{
    using System.Data.Entity;

    public class TweetDbContext : DbContext
    {
        public TweetDbContext() : base("name=TweetDb")
        {
            Database.SetInitializer(new TweetDbInitializer());
        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}