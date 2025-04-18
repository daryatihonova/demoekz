using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tihonova_demo.Models
{
    public partial class Tihonova_demoContext : DbContext
    {
        private static Tihonova_demoContext _context;
        public static Tihonova_demoContext GetContext()
        {
            if (_context == null)
                _context = new Tihonova_demoContext();
            return _context;
        }
        public Tihonova_demoContext()
        {
        }

        public Tihonova_demoContext(DbContextOptions<Tihonova_demoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ContractCientRoom> ContractCientRoom { get; set; }
        public virtual DbSet<HotelRoom> HotelRoom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=hqvla3302s01\\KITP;Initial Catalog=Tihonova_demo;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.BonusCard)
                    .HasColumnName("Bonus_Card")
                    .HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.DateBirthday)
                    .HasColumnName("Date_Birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Flat).HasMaxLength(255);

                entity.Property(e => e.Home).HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Sex).HasMaxLength(2);

                entity.Property(e => e.Surname).HasMaxLength(255);
            });

            modelBuilder.Entity<ContractCientRoom>(entity =>
            {
                entity.ToTable("Contract_Cient_Room");

                entity.Property(e => e.ContractCientRoomId).HasColumnName("Contract_Cient_Room_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.DateContract)
                    .HasColumnName("Date_Contract")
                    .HasColumnType("date");

                entity.Property(e => e.DateExp)
                    .HasColumnName("Date_Exp")
                    .HasColumnType("date");

                entity.Property(e => e.DateImp)
                    .HasColumnName("Date_Imp")
                    .HasColumnType("date");

                entity.Property(e => e.HotelRoomId).HasColumnName("Hotel_Room_ID");

                entity.Property(e => e.Sum).HasColumnType("money");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ContractCientRoom)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Contract_Cient_Room_Client");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.ContractCientRoom)
                    .HasForeignKey(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Contract_Cient_Room_Hotel_Room");
            });

            modelBuilder.Entity<HotelRoom>(entity =>
            {
                entity.ToTable("Hotel_Room");

                entity.Property(e => e.HotelRoomId).HasColumnName("Hotel_Room_ID");

                entity.Property(e => e.CountSeats).HasColumnName("Count_Seats");

                entity.Property(e => e.HotelRoomDescription)
                    .HasColumnName("Hotel_Room_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
