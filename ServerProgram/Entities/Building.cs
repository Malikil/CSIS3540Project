namespace ServerProgram.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Building")]
    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            Floors = new HashSet<Floor>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Floor> Floors { get; set; }

        public DBEntities.Building Simplify()
        {
            return new DBEntities.Building()
            {
                BuildingID = BuildingID,
                Name = Name
            };
        }
    }
}
