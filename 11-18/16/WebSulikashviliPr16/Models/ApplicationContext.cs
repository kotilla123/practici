﻿using Microsoft.EntityFrameworkCore;

namespace WebSulikashviliPr16.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
