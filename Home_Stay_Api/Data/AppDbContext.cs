using Home_Stay_Api.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.DataEF.Repositories
{
    public class ModelBuilderExtensions : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public ModelBuilderExtensions ( DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUsers").HasKey(x => x.Id);
            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(x =>new { x.RoleId, x.UserId });
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoles").HasKey(x => x.Id);
            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId });
            base.OnModelCreating(builder);
        }
    }
    public DbSet<> 
}
