﻿using Microsoft.EntityFrameworkCore;
using Testing1.Models;

namespace Testing1.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
  }
}
