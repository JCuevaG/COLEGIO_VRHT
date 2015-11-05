namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.EstadoCivil")]
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Alumno = new HashSet<Alumno>();
            Profesor = new HashSet<Profesor>();
        }

        [Key]
        public int IdEstadoCivil { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public bool FlagEstado { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }

        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
