using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

    public class DBClient : IdentityDbContext
    {
        public DBClient (DbContextOptions<DBClient> options)
            : base(options)
        {
        }

        public DbSet<ClientModel> ClientModel { get; set; }
    }