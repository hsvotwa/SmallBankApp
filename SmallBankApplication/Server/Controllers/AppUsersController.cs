using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSwag.Annotations;
using SmallBankApplication.Server.Data;
using SmallBankApplication.Server.Models;
using SmallBankApplication.Shared.Models;

namespace TwinkleAPI.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;

        public ApplicationUsersController(ApplicationDbContext context)
        {
            _Context = context;
        }

        [SwaggerResponse(typeof(ApiBooleanResponse))]
        [HttpPost("Create")]
        public async Task<ApiBooleanResponse> Create(ApplicationUser _ApplicationUser)
        {
            if (!ModelState.IsValid)
            {
                return new ApiBooleanResponse
                {
                    Success = false,
                    Description = "Invalid fields"
                };
            }
            ApplicationUser _ApplicationUserExisting = await _Context.ApplicationUsers.FirstAsync(_Rec => _Rec.Id == _ApplicationUser.Id);
            _Context.ApplicationUsers.Update(_ApplicationUser);
            try
            {
                bool result = await _Context.SaveChangesAsync() > 0;
                return new ApiBooleanResponse
                {
                    Success = result,
                    Description = result ? "Success" : "Error saving record"
                };
            }
            catch (DbUpdateException)
            {
            }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error saving record"
            };
        }
    }
}