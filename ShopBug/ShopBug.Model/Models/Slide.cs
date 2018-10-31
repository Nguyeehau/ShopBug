namespace ShopBug.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public int? DispalyOrder { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [MaxLength(250)]
        public byte[] ModifiedBy { get; set; }

        public bool? Status { get; set; }
    }
}
