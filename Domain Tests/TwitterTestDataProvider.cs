namespace Domain.Tests
{
    using Model;
    using System;
    using System.Collections.Generic;

    public static class TwitterTestDataProvider
    {
        public static IEnumerable<Tweet> GetTwelveTestTweets()
        {
            return new List<Tweet>
            {
                new Tweet { Timestamp = DateTime.Parse("18-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("11-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("12-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("28-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("17-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("09-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("07-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("21-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("22-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("25-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("30-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("01-March-2014") },
                new Tweet { Timestamp = DateTime.Parse("02-March-2014"), User = "Antfie" }
            };
        }
    }
}