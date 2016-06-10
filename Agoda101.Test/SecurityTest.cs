using NUnit.Framework;

namespace Agoda101.Testing
{
    [TestFixture]
    public class SecurityTest
    {

        [Test]
        [TestCase("Lee")]
        public void AddTestThatDoesNothing(string name)
        {
            var service = new Security();

            var allowed = service.LetMeIn(name);

            Assert.IsTrue(allowed);
        }

        [Test]
        [TestCase("Lee")]
        [TestCase("Snir")]
        [TestCase("Nir")]
        [TestCase("Mickey")]
        [TestCase("Tum")]
        public void AllowedIn(string name)
        {
            var service = new Security();

            var allowed = service.LetMeIn(name);

            Assert.IsTrue(allowed);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void NotAllowedIn(string name)
        {
            var service = new Security();

            var allowed = service.LetMeIn(name);

            Assert.IsFalse(allowed);
        }
    }
}
