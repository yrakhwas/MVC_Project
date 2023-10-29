using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EstablishentDbContext: DbContext
    {
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingridient> Ingridients {  get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Salad> Salads { get; set; }
        public DbSet<PizzaIngridients> PizzaIngridients { get; set; }   
        public DbSet<SushiIngridients> SushiIngridients { get; set; }
        public DbSet <SaladIngridients> SaladIngridients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                          Initial Catalog=EstablishentDb;
                                          Integrated Security=True;
                                          Connect Timeout=30;
                                          Encrypt=False;
                                          Trust Server Certificate=False;
                                          Application Intent=ReadWrite;
                                          MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Credentials>().HasKey(c => c.Id);
            modelBuilder.Entity<Credentials>().Property(c => c.Id)
                                            .ValueGeneratedOnAdd()
                                            .UseIdentityColumn();
            modelBuilder.Entity<Credentials>().Property(c => c.Password)
                                            .IsRequired();
            modelBuilder.Entity<Credentials>().Property(c => c.Login)
                                            .IsRequired();
            modelBuilder.Entity<Credentials>().Property(c => c.Name)
                                            .IsRequired();
            modelBuilder.Entity<Credentials>().Property(c => c.PhoneNumber)
                                            .IsRequired();

            modelBuilder.Entity<User>().HasKey(u => u.CredentialsId);
            modelBuilder.Entity<Ingridient>().HasKey(i => i.Id);
            modelBuilder.Entity<Ingridient>().Property(i => i.Name).IsRequired();

            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().Property(p=>p.Id)
                                            .ValueGeneratedOnAdd()
                                            .UseIdentityColumn();
            modelBuilder.Entity<Pizza>().Property(p=>p.Cost)
                                            .IsRequired();
            modelBuilder.Entity<Pizza>().Property(p => p.Name)
                                            .IsRequired();

            modelBuilder.Entity<Sushi>().HasKey(s => s.Id);
            modelBuilder.Entity<Sushi>().Property(s => s.Id)
                                            .ValueGeneratedOnAdd()
                                            .UseIdentityColumn();
            modelBuilder.Entity<Sushi>().Property(s => s.Cost)
                                            .IsRequired();
            modelBuilder.Entity<Sushi>().Property(s => s.Name)
                                            .IsRequired();


            modelBuilder.Entity<Salad>().HasKey(sal => sal.Id);
            modelBuilder.Entity<Salad>().Property(sal => sal.Id)
                                            .ValueGeneratedOnAdd()
                                            .UseIdentityColumn();
            modelBuilder.Entity<Salad>().Property(sal => sal.Cost)
                                            .IsRequired();
            modelBuilder.Entity<Salad>().Property(sal => sal.Name)
                                            .IsRequired();



            modelBuilder.Entity<Credentials>().HasOne(c => c.User)
                .WithOne(u => u.Credentials)
                .HasForeignKey<User>(u => u.CredentialsId);

        }

    }
}