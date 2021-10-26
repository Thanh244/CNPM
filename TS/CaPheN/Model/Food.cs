namespace CaPheN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            Bills = new HashSet<Bill>();
            BillinFoes = new HashSet<BillinFo>();
        }

        [Key]
        public int idFood { get; set; }

        [Required]
        [StringLength(100)]
        public string nameFood { get; set; }

        public int idCategory { get; set; }

        public double price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillinFo> BillinFoes { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
    }
}
