namespace ServerProgram
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Floor")]
    public partial class Floor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Floor()
        {
            DormRooms = new HashSet<DormRoom>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FloorID { get; set; }

        public int BuildingID { get; set; }

        public int FloorNum { get; set; }

        public virtual Building Building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DormRoom> DormRooms { get; set; }
    }
}
