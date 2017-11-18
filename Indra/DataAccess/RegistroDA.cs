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

        public List<RegistroBO> TodosLosRegistros()
        {
            SqlCommand cmd = new SqlCommand("TodosLosRegistros", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();

            List<RegistroBO> ListaRegistros = new List<RegistroBO>();

            RegistroBO _registroBO;

            while (reader.Read())
            {
                _registroBO = new RegistroBO();
                _registroBO.ID = int.Parse(reader["ID"].ToString());
                _registroBO.Nombre = reader["Nombre"].ToString();
                _registroBO.Respuesta = double.Parse(reader["Respuesta"].ToString());
                _registroBO.FechaRegistro = DateTime.Parse(reader["FechaRegistro"].ToString());
                ListaRegistros.Add(_registroBO);
            }

            return ListaRegistros;
        }

        public int EliminarRegistro(RegistroBO _registroBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarRegistro", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", _registroBO.ID);                

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