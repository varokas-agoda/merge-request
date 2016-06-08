using NUnit.Framework;

namespace Agoda101.Testing
{
    [TestFixture]
    public class SecurityTest
    {
        [Test]
        [TestCase("Lee")]
        [TestCase("Joel")]
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
