namespace Solution.VRHT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Profesor")]
    public partial class Profesor
    {
        public Profesor()
        {
            CursoProfesor = new HashSet<CursoProfesor>();
        }

        [Key]
        public int IdProfesor { get; set; }

        public int IdEstadoCivil { get; set; }

        public int IdEspecialidad { get; set; }

        public int IdCargo { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int AñosExperiencia { get; set; }

        [StringLength(250)]
        public string CorreoPersonal { get; set; }

        [StringLength(250)]
        public string CorreoCorporativo { get; set; }

        public DateTime FechaEgreso { get; set; }

        [Required]
        [StringLength(250)]
        public string InstitucionEgresado { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(9)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(9)]
        public string Celular { get; set; }

        public bool FlagEstado { get; set; }

        public int IdSexo { get; set; }

        [MaxLength(1)]
        public byte[] Foto { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual ICollection<CursoProfesor> CursoProfesor { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        public virtual EstadoCivil EstadoCivil { get; set; }
    }
}
