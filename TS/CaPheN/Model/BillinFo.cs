namespace CaPheN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillinFo")]
    public partial class BillinFo
    {
        [Key]
        public int idBillinFo { get; set; }

        public int idBill { get; set; }

        public int idFood { get; set; }

        public int SL { get; set; }

        public double? ThanhTien { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Food Food { get; set; }
    }
}
