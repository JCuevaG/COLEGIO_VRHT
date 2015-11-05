namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Nota")]
    public partial class Nota
    {
        [Key]
        public int IdNota { get; set; }

        public int IdCurso { get; set; }

        [Column("Nota")]
        public int? Nota1 { get; set; }

        public int IdAlumno { get; set; }

        public bool FlagEstado { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
