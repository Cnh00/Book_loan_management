using projet.Model;
using Microsoft.EntityFrameworkCore;

namespace projet.data
{
    public class ApplicationDbContext :DbContext
    { 
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override  void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=projet;Integrated Security=True");
        }
        public DbSet<Activite> Actiivte { get; set; }
        public DbSet<Admin> Admin { get; set; }
      public  DbSet<Client> Client { get; set;}
        public DbSet<Event> Event { get; set; }
        public DbSet<Guide> Guide { get; set; }
    
        public DbSet<Ville> Ville { get; set;} 
        public DbSet<projet.Model.userDTO>? userDTO { get; set; }
    
    }
}
