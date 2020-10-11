using AspNetCoreWebApi.SignUp;

namespace JsonSerializationTests
{
    public static class SignUpScenario
    {
        public const string Json =
            "{\"email\":\"kenny.pflug@synnotech.de\",\"firstName\":\"Kenny\",\"lastName\":\"Pflug\",\"organizationId\":2}";

        public static readonly SignUpDto MutableObject = new SignUpDto
        {
            Email = "kenny.pflug@synnotech.de",
            FirstName = "Kenny",
            LastName = "Pflug",
            OrganizationId = 2
        };
    }
}