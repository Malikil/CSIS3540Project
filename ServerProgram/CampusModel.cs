namespace ServerProgram
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CampusModel : DbContext
    {
        public CampusModel()
            : base("name=CampusConnection")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<DormRoom> DormRooms { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Reservation)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<Building>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Floors)
                .WithRequired(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DormRoom>()
                .HasOptional(e => e.Reservation)
                .WithRequired(e => e.DormRoom);

            modelBuilder.Entity<Floor>()
                .HasMany(e => e.DormRooms)
                .WithRequired(e => e.Floor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
