﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PwdLess.Models;

namespace PwdLess.Data
{
    public class ApplicationDbContext : ApplicationDbContext<string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<string>> options) : base(options)
        {
        }
    }

    // Customise generic types here
    public class ApplicationDbContext<TKey> : IdentityDbContext<ApplicationUser<TKey>, IdentityRole<TKey>, TKey>
        where TKey : IEquatable<TKey>
    {
        public DbSet<AuthEvent> AuthEvents;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<TKey>> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
