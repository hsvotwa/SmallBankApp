using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmallBankApp.Server.Data;
using SmallBankApp.Server.Services;
using SmallBankApp.Shared.Models;

namespace SmallBankApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LookupsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IInitLookupsService _initLookupsService;

        public LookupsController(ApplicationDbContext context, IInitLookupsService initLookupsService)
        {
            _context = context;
            _initLookupsService = initLookupsService;
        }

        [Route("get-all-account-types")]
        public async Task<List<AccountType>> GetAllAccountTypes()
        {
            return await _context.AccountTypes.ToListAsync();
        }

        [Route("get-all-currencies")]
        public async Task<List<Currency>> GetAllCurrencies()
        {
            return await _context.Currencies.ToListAsync();
        }

        public async Task<bool> InitAll()
        {
            _initLookupsService.InitAccountTypes();
            _initLookupsService.InitCurrencies();
            return true;
        }
    }
}
