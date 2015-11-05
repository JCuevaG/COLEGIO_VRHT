namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.EstadoDetalle")]
    public partial class EstadoDetalle
    {
        public EstadoDetalle()
        {
            TipoUsuario = new HashSet<TipoUsuario>();
        }

        [Key]
        public int IdEstadoDetalle { get; set; }

        public int IdEstado { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Estado Estado1 { get; set; }

        public virtual ICollection<TipoUsuario> TipoUsuario { get; set; }
    }
}
