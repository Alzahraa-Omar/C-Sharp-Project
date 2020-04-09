namespace C_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }

        public double CategoryCost { get; set; }

        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
