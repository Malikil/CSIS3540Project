namespace ServerProgram.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResID { get; set; }

        public int AccountID { get; set; }

        public int RoomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public virtual Account Account { get; set; }

        public virtual DormRoom DormRoom { get; set; }
        
        public DBEntities.Reservation Simplify()
        {
            return new DBEntities.Reservation()
            {
                ResID = ResID,
                AccountID = AccountID,
                RoomID = RoomID,
                StartDate = StartDate,
                EndDate = EndDate
            };
        }
    }
}
