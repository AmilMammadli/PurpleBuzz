﻿using Microsoft.EntityFrameworkCore;
using PrupleBuzz.Models;

namespace PrupleBuzz.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
    }
}
