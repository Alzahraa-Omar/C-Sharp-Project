namespace C_Project
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Tadabeer : DbContext
    {
        public Tadabeer()
            : base("name=Tadabeer")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
