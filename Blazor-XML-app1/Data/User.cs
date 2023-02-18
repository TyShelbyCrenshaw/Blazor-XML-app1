namespace Blazor_XML_app1.Data
{
    //stores Values from UserTest.xml
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsBusinessContact { get; set; }
        public bool IsAccountingContact { get; set; }
        public bool IsTechnicalContact { get; set; }
        public bool HasApiAccess { get; set; }
    }
}
