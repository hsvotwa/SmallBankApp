using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SmallBankApplication.Server.Models;
using SmallBankApplication.Shared.Models;
using System;
using System.Linq;

namespace SmallBankApplication.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        //Lookups
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        //Data
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
              .SelectMany(t => t.GetForeignKeys())
              .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var _vEntries = ChangeTracker
                .Entries()
                .Where(_Entry => (_Entry.Entity is HasCreatedAndLastModified) && (
                        _Entry.State == EntityState.Added
                        || _Entry.State == EntityState.Modified));
            foreach (var _vEntityEntry in _vEntries)
            {
                ((HasCreatedAndLastModified)_vEntityEntry.Entity).LastModified = DateTime.Now;
                if (_vEntityEntry.State == EntityState.Added)
                {
                    ((HasCreatedAndLastModified)_vEntityEntry.Entity).Created = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
