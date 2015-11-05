namespace Solution.VRHT.Entity
{
    using Solution.VRHT.Common.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

    [Table("Maestro.Alumno")]
    public partial class Alumno
    {
        public Alumno()
        {
            AlumnoAula = new HashSet<AlumnoAula>();
            Nota = new HashSet<Nota>();
        }

        [Key]
        public int IdAlumno { get; set; }

        public int IdEstadoCivil { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreApoderado { get; set; }

        [Required]
        [StringLength(1)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        public int Edad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(250)]
        public string CorreoPersonal { get; set; }

        [StringLength(250)]
        public string CorreoCorporativo { get; set; }

        [Required]
        [StringLength(9)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(1)]
        public string Celular { get; set; }

        public DateTime? FechaEgreso { get; set; }

        public bool FlagEstado { get; set; }

        public int IdSexo { get; set; }

        [Required]
        [MaxLength(1)]
        public byte[] Foto { get; set; }

        public virtual EstadoCivil EstadoCivil { get; set; }

        public virtual Sexo Sexo { get; set; }

        public virtual ICollection<AlumnoAula> AlumnoAula { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }


        public enum Procedure
        {
            [StringValue("Admision.Usp_Ins_Alumno")]
            Admision_Usp_Ins_Alumno
        }
    }
}
