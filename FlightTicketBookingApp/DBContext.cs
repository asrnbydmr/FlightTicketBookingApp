# pragma warning disable

using FlightTicketBookingApp.Models;
using FlightTicketBookingApp.Control_Data;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketBookingApp
{
    public partial class DBContext : DbContext
    {
        public virtual DbSet<ModelAircraft> aircrafts { get; set; }
        public virtual DbSet<ModelLocation> locations { get; set; }
        public virtual DbSet<ModelReservation> reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DB.DBPath}");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelAircraft>(entity =>
            {
                entity.ToTable("Aircraft");
                entity.HasKey(e => e.IdAircraft);
                entity.Property(e => e.AircraftModel).HasColumnType("TEXT");
                entity.Property(e => e.AircraftBrand).HasColumnType("TEXT");
                entity.Property(e => e.AircraftSerialNo).HasColumnType("TEXT");
                entity.Property(e => e.AircraftSeatCapacity).HasColumnType("INTEGER");
            });

            modelBuilder.Entity<ModelLocation>(entity =>
            {
                entity.ToTable("Location");
                entity.HasKey(e => e.IdLocation);
                entity.Property(e => e.Country).HasColumnType("TEXT");
                entity.Property(e => e.City).HasColumnType("TEXT");
                entity.Property(e => e.Airport).HasColumnType("TEXT");
                entity.Property(e => e.ActivePassive).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<ModelReservation>(entity =>
            {
                entity.ToTable("Reservation");
                entity.HasKey(e => e.IdReservation);
                entity.Property(e => e.AircraftId).HasColumnType("INTEGER");
                entity.Property(e => e.LocationId).HasColumnType("INTEGER");
                entity.Property(e => e.Date).HasColumnType("TEXT");
                entity.Property(e => e.CustomerIDNo).HasColumnType("TEXT");
                entity.Property(e => e.CustomerName).HasColumnType("TEXT");
                entity.Property(e => e.CustomerSurname).HasColumnType("TEXT");
                entity.Property(e => e.CustomerGender).HasColumnType("TEXT");
                entity.Property(e => e.SeatNo).HasColumnType("TEXT");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
