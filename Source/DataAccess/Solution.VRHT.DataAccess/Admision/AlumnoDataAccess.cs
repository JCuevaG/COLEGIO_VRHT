using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Solution.VRHT.Common.Infraestructure;
using Solution.VRHT.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.VRHT.DataAccess.Admision
{
    public class AlumnoDataAccess
    {
        private Database oDatabase = EnterpriseLibraryContainer.Current.GetInstance<Database>("");

        public int RegistrarAlumno(Alumno alumno)
        {
            DbCommand oDbCommand = oDatabase.GetStoredProcCommand(StringEnum.GetStringValue(Alumno.Procedure.Admision_Usp_Ins_Alumno)
                                                                  ,alumno.NombreApoderado);
            return oDatabase.ExecuteNonQuery(oDbCommand);;
        }

    }
}
