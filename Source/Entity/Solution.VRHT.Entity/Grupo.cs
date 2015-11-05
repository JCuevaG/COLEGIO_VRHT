namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Grupo")]
    public partial class Grupo
    {
        public Grupo()
        {
            Parametro = new HashSet<Parametro>();
        }

        [Key]
        public int IdGrupo { get; set; }

        [Required]
        [StringLength(1)]
        public string Descripcion { get; set; }

        public virtual ICollection<Parametro> Parametro { get; set; }
    }
}
