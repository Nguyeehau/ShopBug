namespace ShopBug.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long ID { get; set; }

        [StringLength(250)]
        public string CustomerName { get; set; }

        public long? CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(50)]
        public string CustomerAddress { get; set; }

        [StringLength(50)]
        public string CustomerMobile { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [MaxLength(250)]
        public byte[] ModifiedBy { get; set; }

        public bool? Status { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
