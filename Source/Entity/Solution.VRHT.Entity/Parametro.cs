namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Parametro")]
    public partial class Parametro
    {
        [Key]
        public int IdParametro { get; set; }

        public int IdGrupo { get; set; }

        public virtual Grupo Grupo { get; set; }
    }
}
