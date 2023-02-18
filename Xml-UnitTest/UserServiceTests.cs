using Blazor_XML_app1.Data;

namespace Blazor_XML_app1
{
    [TestFixture]
    public class UserServiceTests
    {
        public UserService service { get; set; }

        [SetUp]
        public void SetUp()
        {
            service = new UserService();
        }

        [Test]
        public void SearchUsers_FirstName()
        {
            var user = service.SearchUsers("Cheryl");

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Count);
            Assert.AreEqual(12348, user[0].Id);
        }

        [Test]
        public void SearchUsers_LastName()
        {
            var user = service.SearchUsers("Perkins");

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Count);
            Assert.AreEqual(12349, user[0].Id);
        }

        [Test]
        public void SearchUsers_FirstName_LastName()
        {
            var user = service.SearchUsers("Courtney Banks");

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Count);
            Assert.AreEqual(12350, user[0].Id);
        }

        [Test]
        public void SearchUsers_Email()
        {
            var user = service.SearchUsers("Michael.Martinez@Cmp465.com");

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Count);
            Assert.AreEqual(12351, user[0].Id);
        }
    }
}
