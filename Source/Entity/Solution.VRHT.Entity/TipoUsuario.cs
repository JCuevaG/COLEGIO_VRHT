namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.TipoUsuario")]
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int IdTipoUsuario { get; set; }

        public int IdEstadoDetalle { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual EstadoDetalle EstadoDetalle { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
