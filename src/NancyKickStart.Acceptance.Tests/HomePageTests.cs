using NUnit.Framework;
using Nancy;
using Nancy.Testing;

namespace NancyKickStart.Acceptance.Tests
{
    [TestFixture]
    public class HomePageTests
    {
        private BrowserResponse _result;

        [SetUp]
        public void SetUp()
        {
            var browser = new Browser(new TestBootstrapper());
            _result = browser.Get("/");
        }

        [Test]
        public void Should_show_home_page_on_root_uri()
        {
            Assert.That(_result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void Should_render_html_page_on_root()
        {            
            Assert.That(_result.Body["html"], Is.Not.Null);
        }

        [Test]
        public void Renders_kickstart_in_head()
        {
            Assert.That(_result.Body.AsString(), Is.StringContaining("kickstart"));
        }
    }
}
