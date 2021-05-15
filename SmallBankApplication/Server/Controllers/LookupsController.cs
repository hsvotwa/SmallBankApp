using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallBankApplication.Server.Data;
using SmallBankApplication.Server.Models;
using SmallBankApplication.Server.Services;
using Microsoft.AspNetCore.Authorization;
using SmallBankApplication.Shared.Models;
using NSwag.Annotations;

namespace SmallBankApplication.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LookupsController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        private readonly IInitLookupService _InitLookupService;

        public LookupsController(ApplicationDbContext context, IInitLookupService initLookupsService)
        {
            _Context = context;
            _InitLookupService = initLookupsService ?? throw new System.ArgumentNullException(nameof(initLookupsService));
        }

        [HttpGet("GetAllAccountTypes")]
        [SwaggerResponse(typeof(List<AccountType>))]
        public async Task<List<AccountType>> GetAllAccountTypes()
        {
            return await _Context.AccountTypes.ToListAsync();
        }

        [HttpGet("GetAllCurrencies")]
        [SwaggerResponse(typeof(List<Currency>))]
        public async Task<List<Currency>> GetAllCurrencies()
        {
            return await _Context.Currencies.ToListAsync();
        }

        [HttpPost("InitAll")]
        [SwaggerResponse(typeof(ApiBooleanResponse))]
        [AllowAnonymous]
        public ApiBooleanResponse InitAll()
        {
            try
            {
                bool _ret = _InitLookupService.InitAccountTypes();
                bool _ret2 = _InitLookupService.InitCurrencies();
                return new ApiBooleanResponse
                {
                    Success = _ret && _ret2,
                    Description = _ret && _ret2 ? "Success" : "Some lookup dataset(s) not updated"
                };
            }
            catch { }
            return new ApiBooleanResponse
            {
                Success = false,
                Description = "Error saving records"
            };
        }
    }
}