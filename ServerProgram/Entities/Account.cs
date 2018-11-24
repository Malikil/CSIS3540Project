namespace ServerProgram.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int AccountID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }

        public int? StudentID { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<Reservation> Reservations{ get; set; }

        public DBEntities.Account Simplify()
        {
            return new DBEntities.Account()
            {
                AccountID = AccountID,
                Username = Username,
                Password = Password,
                StudentID = StudentID
            };
        }
    }
}
