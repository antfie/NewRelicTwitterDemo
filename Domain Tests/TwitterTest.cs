namespace Domain.Tests
{
    using Model.Repositories;
    using NSubstitute;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class TwitterTest
    {
        private ITwitterRepository _repository;
        private Twitter _twitter;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            _repository = Substitute.For<ITwitterRepository>();
            _repository.GetTweets().Returns(TwitterTestDataProvider.GetTwelveTestTweets());
        }

        [SetUp]
        public void SetUp()
        {
            _twitter = new Twitter(_repository);
        }

        [Test]
        public void GetLatestTweets_GivenTwelveTweets_ShouldReturnTheLatestTen()
        {
            var result = _twitter.GetLatestTweets();

            Assert.That(result.Count(), Is.EqualTo(10));
        }

        [Test]
        public void GetLatestTweets_GivenSomeTweets_ShouldReturnTheTweetsInTimestampDescendingOrder()
        {
            var result = _twitter.GetLatestTweets().ToList();

            var expectedFirstTimestamp = DateTime.Parse("30-March-2014");
            var expectedLastTimestamp = DateTime.Parse("09-March-2014");

            Assert.That(result.First().Timestamp, Is.EqualTo(expectedFirstTimestamp));
            Assert.That(result.Last().Timestamp, Is.EqualTo(expectedLastTimestamp));
        }

        [Test]
        public void GetLatestTweets_ForASpecificUserGivenSomeTweets_ShouldReturnTheTweetsInTimestampDescendingOrderForThatUser()
        {
            var result = _twitter.GetLatestTweets("Antfie").ToList();

            var expected = DateTime.Parse("02-March-2014");
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result.First().Timestamp, Is.EqualTo(expected));
        }
    }
}