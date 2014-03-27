namespace Model.Persistance
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class TweetDbInitializer : CreateDatabaseIfNotExists<TweetDbContext>
    {
        protected override void Seed(TweetDbContext context)
        {
            var now = DateTime.Now;

            context.Tweets.AddRange(new List<Tweet>
            {
                new Tweet
                {
                    Timestamp = now.Subtract(new TimeSpan(0,0,2)),
                    Message = "Test message",
                    User = "Antfie"
                },
                new Tweet
                {
                    Timestamp = now.Subtract(new TimeSpan(0,0,1)),
                    Message = "Hello, World!",
                    User = "Antfie"
                }
            });

            context.SaveChanges();
        }
    }
}