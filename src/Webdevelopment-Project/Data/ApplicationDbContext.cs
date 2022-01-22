using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Webdevelopment_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Webdevelopment_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ChatUser>()
                .HasKey(x => new { x.ChatId , x.UserId });
        }
        public DbSet<ApplicationUser> AppUsers { get; set; }
        public DbSet<Melding> Melding { get; set; }
        public DbSet<Intake> Intake {get;set;}

        
        public DbSet<Afspraak> Afspraak { get; set; }
        internal Task<IdentityResult> CreateAsync(IdentityRole identityRole)
    {
        throw new NotImplementedException();
    }
        public DbSet<Hulpverlener> Hulpverlener { get; set; }
        public DbSet<Webdevelopment_Project.Models.Client> Client { get; set; }
        public DbSet<Webdevelopment_Project.Models.Report> Report { get; set; }
        public DbSet<Behandeling> Behandeling { get; set; }
        
        // public DbSet<Hulpverlener> Hulpverlener { get; set; }
        // public DbSet<Hulpverlener> Hulpverlener { get; set; }
    }
}
