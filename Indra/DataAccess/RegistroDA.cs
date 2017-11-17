using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BussinessObject;

namespace DataAccess
{
    public class RegistroDA
    {       

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionIndraDB"].ToString());

        public int AdicionarRegistro(RegistroBO _registroBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarRegistro", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", _registroBO.Nombre);
                cmd.Parameters.AddWithValue("@Respuesta", _registroBO.Respuesta);
                cmd.Parameters.AddWithValue("@FechaRegistro", _registroBO.FechaRegistro);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();

                return Result;
            }

            catch
            {
                throw;
            }
        }
    }
}