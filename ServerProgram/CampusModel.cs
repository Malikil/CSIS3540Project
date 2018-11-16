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
        }
    }
}
