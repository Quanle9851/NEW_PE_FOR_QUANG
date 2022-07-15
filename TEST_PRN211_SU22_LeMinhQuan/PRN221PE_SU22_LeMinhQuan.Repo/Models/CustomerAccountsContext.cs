using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System.IO;
using Microsoft.Extensions.Configuration;
#nullable disable

namespace PRN221PE_SU22_LeMinhQuan.Repo.Models
{
    public partial class CustomerAccountsContext : DbContext
    {
        public CustomerAccountsContext()
        {
        }

        public CustomerAccountsContext(DbContextOptions<CustomerAccountsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:CustomersAccountDB"];
            return strConn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string cs = GetConnectionString();
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(cs);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.CustomersDesc).HasMaxLength(200);
            });

            modelBuilder.Entity<CustomerAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__Customer__349DA58652BA37D1");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAccounts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CustomerA__Custo__286302EC");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
