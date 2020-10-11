namespace AspNetCoreWebApi.Model
{
    public sealed class User : Entity<User>
    {
        public User(int id,
                    string firstName,
                    string lastName,
                    string email,
                    Organization organization)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Organization = organization;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public Organization Organization { get; }
    }
}