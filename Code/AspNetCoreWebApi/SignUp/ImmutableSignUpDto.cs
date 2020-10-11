namespace AspNetCoreWebApi.SignUp
{
    public sealed class ImmutableSignUpDto
    {
        public ImmutableSignUpDto(string email,
                                  string firstName,
                                  string lastName,
                                  int organizationId)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            OrganizationId = organizationId;
        }

        public string Email { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int OrganizationId { get; }
    }
}