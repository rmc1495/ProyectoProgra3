using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CD_PROYECTO
{
    public class CdFlight
    {
        private int idFlight;
        private int idTicket;
        private int idPlane;
        private String origen;
        private String destino;
        private String horaPartida;

        private String horaLlegada;

        public int IdFlight
        {
            get { return idFlight; }
            set { idFlight = value; }
        }

        public int IdTicket
        {
            get { return idTicket; }
            set { idTicket = value; }
        }
      
        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; }
        }

        public String Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public String Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public String HoraPartida
        {
            get { return horaPartida; }
            set { horaPartida = value; }
        }
        
        public String HoraLlegada
        {
            get { return horaLlegada; }
            set { horaLlegada = value; }
        }

        public void GuardarTickete(CdFlight flight)
        {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader fl;

            comando.CommandText = "sp_RegisterFlight";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTicket ", flight.IdTicket);
            comando.Parameters.AddWithValue("@idPlane", flight.IdPlane);
            comando.Parameters.AddWithValue("@origen", flight.Origen);
            comando.Parameters.AddWithValue("@destino", flight.Destino);
            comando.Parameters.AddWithValue("@horaPartida", flight.HoraPartida);
            comando.Parameters.AddWithValue("@horaLlegada", flight.HoraLlegada);
            conexion.Open();
            fl = comando.ExecuteReader();
            conexion.Close();

        }

        public void ModifyTickete(CdFlight mdfFlight)
        {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader fl;

            comando.CommandText = "sp_UpdateTicket";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId", mdfFlight.IdFlight);
            comando.Parameters.AddWithValue("@idTicket ", mdfFlight.IdTicket);
            comando.Parameters.AddWithValue("@idPlane", mdfFlight.IdPlane);
            comando.Parameters.AddWithValue("@origen", mdfFlight.Origen);
            comando.Parameters.AddWithValue("@destino", mdfFlight.Destino);
            comando.Parameters.AddWithValue("@horaPartida", mdfFlight.HoraPartida);
            comando.Parameters.AddWithValue("@horaLlegada", mdfFlight.HoraLlegada);
            conexion.Open();
            fl = comando.ExecuteReader();
            conexion.Close();

        }
    }
}
