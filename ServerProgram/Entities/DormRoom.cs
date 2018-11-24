namespace ServerProgram.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DormRoom")]
    public partial class DormRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }

        public int Size { get; set; }

        public int Capacity { get; set; }

        public int FloorID { get; set; }

        public virtual Floor Floor { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public DBEntities.DormRoom Simplify()
        {
            return new DBEntities.DormRoom()
            {
                RoomID = RoomID,
                Size = Size,
                Capacity = Capacity,
                FloorID = FloorID
            };
        }
    }
}
