using Solution.VRHT.DataAccess.Admision;
using Solution.VRHT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Test.BusinessLogic.Admision
{
    public class AlumnoBusinessLogic
    {
        public int Registrar(Alumno alumno)
        {
            return new AlumnoDataAccess().RegistrarAlumno(alumno);
        }
    }
}
