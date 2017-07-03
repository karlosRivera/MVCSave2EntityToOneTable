namespace MVCSave2EntityToOneTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Salary { get; set; }
    }
}
