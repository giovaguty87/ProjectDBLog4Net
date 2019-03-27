
using Common.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TestProject.Common;

namespace TestProject.Dao
{
    public class ProcessDao
    {
        private readonly ILog _log;
        private SqlConnection cn;
        private string conn = ConfigurationManager.AppSettings["ProcessTestDaoConnString"];

        public ProcessDao()
        {
            _log = LogManager.GetLogger(GetType());

            _log.Info($"Process DAO.");
        }

        public List<Empleado> GetEmpleados()
        {

            int i = 0;
            SqlDataReader sqldr;
            List<Empleado> lstEmpleados = new List<Empleado>();

            try
            {
                string cmdText = "select * from [Cuadrante].[dbo].[tblCHEmpleados] with(nolock)";

                using (cn = new SqlConnection(this.conn))
                {
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = CommandType.Text;
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    _log.Info("Executing query for employees to database..");

                    sqldr = cmd.ExecuteReader();

                    _log.Info("Loading employees...");

                    while (sqldr.Read())
                    {
                        Empleado empleado = new Empleado
                        {
                            Id = sqldr.GetInt32(0),
                            Nombre = sqldr.GetString(1),
                            IdRol = sqldr.GetInt32(2),
                            cargo = sqldr.GetString(3),
                            profesion = sqldr.GetString(4),

                        };

                        i++;
                        lstEmpleados.Add(empleado);
                    }
                }

                return lstEmpleados;
            }
            catch (Exception ex)
            {
                _log.Error($"Error : {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}