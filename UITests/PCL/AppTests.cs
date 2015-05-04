using System;
using NUnit.Framework;

namespace XamarinSeed.Tests
{
    [TestFixture]
    public class AppTests
    {
        [SetUp]
        public void BeforeEachTest()
        {
            App.Instance;
        }

        [Test]
        public void Initialize()
    }
}

