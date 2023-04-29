using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using P._09_MVC.Models;

namespace PracticaMVC.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }
      
    }

}