using System;
using System.Threading.Tasks;
using AspNetCoreWebApi.Model;

namespace AspNetCoreWebApi.SignUp
{
    public interface ISignUpSession : IAsyncDisposable
    {
        Task<Organization?> GetOrganizationAsync(int organizationId);

        Task SaveChangesAsync();
    }
}