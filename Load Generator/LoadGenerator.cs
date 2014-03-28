namespace LoadGenerator
{
    using System;
    using System.Net;
    using System.Threading;

    public class LoadGenerator
    {
        private readonly Uri _uri = new Uri("http://localhost/NewRelicTwitterDemo/");

        public LoadGenerator()
        {
            for (var i = 0; i < 1000; i++)
            {
                using (var client = new WebClient())
                {
                    client.DownloadStringAsync(_uri);
                }

                Thread.Sleep(500);
            }
        }
    }
}