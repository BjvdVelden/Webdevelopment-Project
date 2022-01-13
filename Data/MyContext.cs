using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Models;

    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Webdevelopment_Project.Models.HulpverlenerModel> HulpverlenerModel { get; set; }

        public DbSet<ClientModel> ClientModel { get; set; }
    }
