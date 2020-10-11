using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.SignUp
{
    [Route("api/signUp")]
    [ApiController]
    public sealed class SignUpController : ControllerBase
    {
        private readonly Func<ISignUpSession> _createSession;

        public SignUpController(Func<ISignUpSession> createSession)
        {
            _createSession = createSession;
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> SignUp(SignUpDto signUpDto)
        {
            await using var session = _createSession();
            var organization = await session.GetOrganizationAsync(signUpDto.OrganizationId);

            if (organization == null)
                return BadRequest($"There is no organization with ID {signUpDto.OrganizationId}");

            if (!organization.TryAddNewUser(signUpDto.FirstName!, signUpDto.LastName!, signUpDto.Email!, out var newUser))
                return BadRequest($"There already is a user with email address \"{signUpDto.Email}\".");

            await session.SaveChangesAsync();

            return new UserDto
            {
                Id = newUser.Id,
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                EmailAddress = newUser.Email,
                OrganizationId = organization.Id,
                OrganizationName = organization.Name
            };
        }
    }

    public sealed class SignUpDto
    {
        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int OrganizationId { get; set; }
    }

    public sealed class UserDto
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? EmailAddress { get; set; }

        public int OrganizationId { get; set; }

        public string? OrganizationName { get; set; }
    }
}