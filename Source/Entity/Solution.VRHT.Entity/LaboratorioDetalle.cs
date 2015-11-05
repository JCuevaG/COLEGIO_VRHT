namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.LaboratorioDetalle")]
    public partial class LaboratorioDetalle
    {
        [Key]
        public int IdLaboratorioDetalle { get; set; }

        public int IdLaboratorio { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
