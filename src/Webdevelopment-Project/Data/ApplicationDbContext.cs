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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ChatUser>()
                .HasKey(x => new { x.ChatId , x.UserId });
        }

        internal Task<IdentityResult> CreateAsync(IdentityRole identityRole)
        {
        throw new NotImplementedException();
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }
        public DbSet<ApplicationUser> AppUsers { get; set; }
        public DbSet<Melding> Melding { get; set; }
        public DbSet<Intake> Intake {get;set;}
        public DbSet<Afspraak> Afspraak { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Behandeling> Behandeling { get; set; }
        public DbSet<ApiKoppel> ApiKoppel { get; set; }
    }
}
