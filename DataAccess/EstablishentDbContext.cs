using DataAccess.Entities;
using DataAccess.Helpers;
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
            modelBuilder.Entity<Pizza>().Property(p => p.Id)
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



            modelBuilder.Entity<User>()
                .HasOne(u => u.Credentials)
                .WithOne(c => c.User)
                .HasForeignKey<User>(u => u.CredentialsId);

            // Зв'язок один-до-багатьох між User та Pizza
            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.Pizzas)
            //    .WithOne()
            //    .HasForeignKey(p => p.Id);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.Sushis)
            //    .WithOne()
            //    .HasForeignKey(s => s.Id);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.Salad)
            //    .WithOne()
            //    .HasForeignKey(sa => sa.Id);

           
            modelBuilder.Entity<Pizza>()
                        .HasMany(p => p.Ingridients)
                        .WithMany(i => i.Pizzas)
                        .UsingEntity<PizzaIngridients>(
                        j => j
                            .HasOne(pi => pi.Ingridient)
                            .WithMany()
                            .HasForeignKey(pi => pi.IngridientId),
                        j => j
                            .HasOne(pi => pi.Pizza)
                            .WithMany()
                            .HasForeignKey(pi => pi.PizzaId),
                        j =>
                        {
                            j.HasKey(pi => new { pi.PizzaId, pi.IngridientId });
                            j.ToTable("PizzaIngridients");
                        }
         );
            modelBuilder.Entity<Sushi>()
                        .HasMany(s => s.Ingridients)
                        .WithMany(i => i.Sushis)
                        .UsingEntity<SushiIngridients>(
                        j => j
                            .HasOne(su => su.Ingridient)
                            .WithMany()
                            .HasForeignKey(su => su.IngridientId),
                        j => j
                            .HasOne(su => su.Sushi)
                            .WithMany()
                            .HasForeignKey(su => su.SushiId),
                        j =>
                        {
                            j.HasKey(su => new { su.SushiId, su.IngridientId });
                            j.ToTable("SushiIngridients");
                        }
         );
            modelBuilder.Entity<Salad>()
                        .HasMany(s => s.Ingridients)
                        .WithMany(i => i.Salads)
                        .UsingEntity<SaladIngridients>(
                        j => j
                            .HasOne(sa => sa.Ingridient)
                            .WithMany()
                            .HasForeignKey(sa => sa.IngridientId),
                        j => j
                            .HasOne(sa => sa.Salad)
                            .WithMany()
                            .HasForeignKey(sa => sa.SaladId),
                        j =>
                        {
                            j.HasKey(sa => new { sa.SaladId, sa.IngridientId });
                            j.ToTable("SaladIngridients");
                        }
         );


            //modelBuilder.SeedCredentials();
            //modelBuilder.SeedUsers();
            //modelBuilder.SeedIngridients();
            //modelBuilder.SeedSushis();
            //modelBuilder.SeedPizzas();
            //modelBuilder.SeedSalads();
            //modelBuilder.SeedSushiIngridient();
            //modelBuilder.SeedSaladIngridient();
            //modelBuilder.SeedPizzaIngridient();
        }

    }
}