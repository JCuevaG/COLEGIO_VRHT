namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.HorarioCurso")]
    public partial class HorarioCurso
    {
        [Key]
        public int IdHorarioCurso { get; set; }

        public int IdCurso { get; set; }

        public int IdAula { get; set; }

        [Required]
        [StringLength(20)]
        public string HoraInicio { get; set; }

        [Required]
        [StringLength(20)]
        public string HoraFin { get; set; }

        public bool FlagEstado { get; set; }

        public virtual Aula Aula { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
