using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NationBuilder.Models
{
    public class NationBuilderContext : IdentityDbContext<ApplicationUser>
    {
        public NationBuilderContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public NationBuilderContext() { }
    }
}