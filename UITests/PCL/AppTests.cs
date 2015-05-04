using System;
using NUnit.Framework;

namespace XamarinSeed.Tests
{
    [TestFixture]
    public class AppTests
    {
        [Test]
        public void Initialize()
        {
            App.Instance;
            Assert.IsNotNull(App.Instance.Navigation);
        }
    }
}

