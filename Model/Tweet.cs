namespace Model
{
    using System;

    public class Tweet
    {
        public int TweetId { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}