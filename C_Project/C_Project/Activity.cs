namespace C_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ActivityName { get; set; }

        public double ActivityCost { get; set; }

        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
