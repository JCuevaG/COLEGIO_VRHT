namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Estado")]
    public partial class Estado
    {
        public Estado()
        {
            EstadoDetalle = new HashSet<EstadoDetalle>();
            TipoUsuario = new HashSet<TipoUsuario>();
        }

        [Key]
        public int IdEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        public virtual ICollection<EstadoDetalle> EstadoDetalle { get; set; }

        public virtual ICollection<TipoUsuario> TipoUsuario { get; set; }
    }
}
