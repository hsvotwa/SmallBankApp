using System.Threading.Tasks;

namespace SmallBankApplication.Client.Services
{
    public interface IAppUserService
    {
        Task<ApiBooleanResponse> Create(ApplicationUser user);
    }
}