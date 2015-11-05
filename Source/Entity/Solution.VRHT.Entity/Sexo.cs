namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Sexo")]
    public partial class Sexo
    {
        public Sexo()
        {
            Alumno = new HashSet<Alumno>();
        }

        [Key]
        public int IdSexo { get; set; }

        [Required]
        [StringLength(20)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string DescripcionCorta { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }
    }
}
