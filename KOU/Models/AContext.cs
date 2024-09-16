using Microsoft.EntityFrameworkCore;

namespace KOU.Models

{
    public class AContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("workstation id=KardeslerOtoservis.mssql.somee.com;packet size=4096;user id=ibrahimaygun58_SQLLogin_1;pwd=oc4agi97rn;data source=KardeslerOtoservis.mssql.somee.com;persist security info=False;initial catalog=KardeslerOtoservis;TrustServerCertificate=True");

        }
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<ArabaSahibi> ArabaSahipleri { get; set; }
        public DbSet<Parca> Parcalar { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}