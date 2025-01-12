//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigireadProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Purchases = new HashSet<Purchases>();
            this.Rentals = new HashSet<Rentals>();
            this.Reviews = new HashSet<Reviews>();
            this.ShoppingCart = new HashSet<ShoppingCart>();
            this.WaitList = new HashSet<WaitList>();
        }
    
        public int BookID { get; set; }
        public string Title { get; set; }
        public string MainAuthor { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public Nullable<decimal> RentalPrice { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<int> AgeRestriction { get; set; }
        public string Genre { get; set; }
        public Nullable<bool> IsAvailable { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsForRent { get; set; }
        public Nullable<decimal> OriginalPrice { get; set; }
        public Nullable<System.DateTime> DiscountEndDate { get; set; }
        public Nullable<bool> IsRented { get; set; }
        public Nullable<bool> IsEPUBAvailable { get; set; }
        public Nullable<bool> IsF2BAvailable { get; set; }
        public Nullable<bool> IsMobiAvailable { get; set; }
        public Nullable<bool> IsPDFAvailable { get; set; }
        public string ImageSrc { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public string Description { get; set; }
        public Nullable<int> StockQuantityRent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchases> Purchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rentals> Rentals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitList> WaitList { get; set; }
    }
}
