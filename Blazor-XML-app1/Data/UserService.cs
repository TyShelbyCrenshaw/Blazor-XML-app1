using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;


namespace Blazor_XML_app1.Data
{
    public class UserService : IUserService
    {
        private XDocument _xml;

        public UserService()
        {
            _xml = XDocument.Load("C:\\Users\\Ty\\source\\repos\\Blazor-XML-app1\\Blazor-XML-app1\\UsersTest.xml");
        }

        public List<User> SearchUsers(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var users = from user in _xml.Descendants("User")
                            where user.Element("FirstName").Value.Contains(input)
                              || user.Element("LastName").Value.Contains(input)
                              || user.Element("Email").Value.Contains(input)
                              || (user.Element("FirstName").Value + " " + user.Element("LastName").Value).Contains(input)
                            select new User
                            {
                                Id = (int)user.Attribute("id"),
                                FirstName = (string)user.Element("FirstName"),
                                LastName = (string)user.Element("LastName"),
                                Email = (string)user.Element("Email"),
                                IsBusinessContact = (bool)user.Element("IsBusinessContact"),
                                IsAccountingContact = (bool)user.Element("IsAccountingContact"),
                                IsTechnicalContact = (bool)user.Element("IsTechnicalContact"),
                                HasApiAccess = (bool)user.Element("HasApiAccess")
                            };

                return users.ToList();
            }
            else { return new List<User>(); }

        }
    }
}
