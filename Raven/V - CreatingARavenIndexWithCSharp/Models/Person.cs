namespace V___CreatingARavenIndexWithCSharp.Models
{
    public class Employe
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Contact
    {
        public string Name { get; set; }
    }

    public class Company
    {
        public string Id { get; set; }
        public Contact Contact { get; set; }
    }

    public class Supplier
    {
        public string Id { get; set; }
        public Contact Contact { get; set; }
    }
}
