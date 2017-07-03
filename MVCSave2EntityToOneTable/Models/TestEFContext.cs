namespace MVCSave2EntityToOneTable
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestEFContext : DbContext
    {
        public TestEFContext()
            : base("name=TestModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ControllerActionItem> ControllerActionItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ControllerActionItem>()
                .Property(e => e.ControllerName)
                .IsUnicode(false);

            modelBuilder.Entity<ControllerActionItem>()
                .Property(e => e.ActionName)
                .IsUnicode(false);
        }
    }
}
