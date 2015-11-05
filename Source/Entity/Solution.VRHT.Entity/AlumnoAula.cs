namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.AlumnoAula")]
    public partial class AlumnoAula
    {
        [Key]
        public int IdAlumnoAula { get; set; }

        public int IdAula { get; set; }

        public int IdAlumno { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Aula Aula { get; set; }
    }
}
