using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context()
        {

        }
        //configuration from settings
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-C0QK8PV\\SQLEXPRESS01;database=DepremzedeBilgiPlatformDb; TrustServerCertificate=True; integrated security=true;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GuestInfo>()
                        .HasKey(c => new { c.GuestId });


            modelBuilder.Entity<HomeInfo>()
                        .HasKey(c => new { c.HomeInfoId });


            modelBuilder.Entity<NeedInfo>()
                        .HasKey(c => new { c.NeedInfoId });


            base.OnModelCreating(modelBuilder);
        }



        public DbSet<GuestInfo> GuestInfos { get; set; }

        public DbSet<HomeInfo> HomeInfos { get; set; }

        public DbSet<NeedInfo> NeedInfos { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }

    }
}
