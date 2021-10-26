namespace CaPheN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillinFoes = new HashSet<BillinFo>();
        }

        [Key]
        public int idBill { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateIn { get; set; }

        public int idFood { get; set; }

        [Required]
        [StringLength(50)]
        public string idNV { get; set; }

        public double? TongTien { get; set; }

        public virtual Food Food { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillinFo> BillinFoes { get; set; }
    }
}
