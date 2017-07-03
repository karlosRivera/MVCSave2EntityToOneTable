namespace MVCSave2EntityToOneTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ControllerActionItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ControllerName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ActionName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleID { get; set; }
    }
}
