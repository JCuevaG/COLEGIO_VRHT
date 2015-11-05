using Solution.VRHT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.VRHT.Web.Models.Admision
{
    public class AlumnoModel
    {

        public Alumno Alumno { get; set; }

        public ListaSexo ListaSexo { get; set; }

        public int SearchIdSexo { get; set; }
    }
}