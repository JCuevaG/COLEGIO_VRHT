namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Especialidad")]
    public partial class Especialidad
    {
        public Especialidad()
        {
            Profesor = new HashSet<Profesor>();
        }

        [Key]
        public int IdEspecialidad { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool FlagEstado { get; set; }

        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
