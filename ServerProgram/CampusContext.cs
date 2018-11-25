using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using ServerProgram.Entities;

namespace ServerProgram
{
    public partial class CampusContext : DbContext
    {
        public CampusContext()
            : base("name=CampusConnection")
        {
        }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<Floor> Floor { get; set; }
        public virtual DbSet<DormRoom> DormRoom { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Floors)
                .WithRequired(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DormRoom>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.DormRoom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Floor>()
                .HasMany(e => e.DormRooms)
                .WithRequired(e => e.Floor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
