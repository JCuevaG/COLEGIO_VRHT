namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Cargo")]
    public partial class Cargo
    {
        public Cargo()
        {
            Profesor = new HashSet<Profesor>();
        }

        [Key]
        public int IdCargo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool FlagEstado { get; set; }

        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
