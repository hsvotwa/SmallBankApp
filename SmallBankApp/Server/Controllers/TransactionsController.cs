using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallBankApp.Server.Data;
using SmallBankApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace SmallBankApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Transaction>> GetAll()
        {
            var applicationDbContext = _context.Transactions.Include(t => t.DestinationAccount).Include(t => t.SourceAccount);
            return await applicationDbContext.ToListAsync();
        }

        public async Task<Transaction> Details(Guid? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _context.Transactions
                .Include(t => t.DestinationAccount)
                .Include(t => t.SourceAccount)
                .FirstOrDefaultAsync(m => m.TransactionID == id);
        }

        [HttpPost]
        public async Task<bool> Create(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction.TransactionID = Guid.NewGuid();
                _context.Add(transaction);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        [HttpPost]
        public async Task<bool> Edit(Guid id, Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                }
            }
            return false;
        }
    }
}