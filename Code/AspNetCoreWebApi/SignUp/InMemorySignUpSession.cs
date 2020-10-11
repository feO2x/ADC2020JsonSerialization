using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreWebApi.Model;

// ReSharper disable All

namespace AspNetCoreWebApi.SignUp
{
    public sealed class InMemorySignUpSession : ISignUpSession
    {
        public InMemorySignUpSession(List<Organization>? organizations = null)
        {
            Organizations = organizations ?? new List<Organization>();
        }

        public List<Organization> Organizations { get; }

        public ValueTask DisposeAsync()
        {
            return new ValueTask(Task.CompletedTask);
        }

        public Task<Organization?> GetOrganizationAsync(int organizationId)
        {
            foreach (var organization in Organizations)
            {
                if (organization.Id == organizationId)
                    return Task.FromResult<Organization?>(organization);
            }

            return Task.FromResult<Organization?>(null);
        }

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }

        public static InMemorySignUpSession CreateDefault()
        {
            var ppedv = new Organization(1, "PPEDV");
            ppedv.TryAddNewUser("Hannes", "Preishuber", "info@ppedv.de", out _);

            var synnotech = new Organization(2, "Synnotech AG");

            return new InMemorySignUpSession(new List<Organization> { ppedv, synnotech });
        }
    }
}