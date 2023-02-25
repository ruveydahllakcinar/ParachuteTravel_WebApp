using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=ParachuteTravelDb.mssql.somee.com;packet size=4096;user id=akcinarruv_SQLLogin_1;pwd=412n689l94;data source=ParachuteTravelDb.mssql.somee.com;persist security info=False;initial catalog=ParachuteTravelDb");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutHeader> AboutHeaders { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactsUses { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<FeatureLargeCard> FeatureLargeCards { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Reservation>Reservations { get; set; }
        public DbSet<Account>Accounts { get; set; }

    }
}
