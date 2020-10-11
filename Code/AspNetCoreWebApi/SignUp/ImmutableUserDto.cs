namespace AspNetCoreWebApi.SignUp
{
    public sealed class ImmutableUserDto
    {
        public ImmutableUserDto(int id,
                                string firstName,
                                string lastName,
                                string emailAddress,
                                int organizationId,
                                string organizationName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            OrganizationId = organizationId;
            OrganizationName = organizationName;
        }
        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string EmailAddress { get; }

        public int OrganizationId { get; }

        public string OrganizationName { get; }
    }
}