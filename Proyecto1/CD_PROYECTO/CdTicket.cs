using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CD_PROYECTO
{
    // CLASE CREADA POR JENNIFFER CHINCHILLA PORRAS 28/06/2015
    public class CdTicket
    {
        private int idTicket;
        private double price;
        private int currency;
        private String ticketState;
        private String idClient;
        private String idFlight;
        private int numSeat;

        public int IdTicket
        {
            get { return idTicket; }
            set { idTicket = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public String TicketState
        {
            get { return ticketState; }
            set { ticketState = value; }
        }

        public String IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public String IdFlight
        {
            get { return idFlight; }
            set { idFlight = value; }
        }

        public int NumSeat
        {
            get { return numSeat; }
            set { numSeat = value; }
        }


        public void GuardarTickete(CdTicket tickete)
        {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader tq;

            comando.CommandText = "sp_RegisterTicket";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pPrice ", tickete.Price);
            comando.Parameters.AddWithValue("@pCurrency", tickete.Currency);
            comando.Parameters.AddWithValue("@pTicketState", tickete.TicketState);
            comando.Parameters.AddWithValue("@pIdClient", tickete.IdClient);
            comando.Parameters.AddWithValue("@pIdFlight", tickete.IdFlight);
            comando.Parameters.AddWithValue("@pNumSeat", tickete.NumSeat);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();

        }

        public void ModifyTickete(CdTicket mdfTickete)
        {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader tq;

            comando.CommandText = "sp_UpdateTicket";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId", mdfTickete.IdTicket);
            comando.Parameters.AddWithValue("@pPrice ", mdfTickete.Price);
            comando.Parameters.AddWithValue("@pCurrency", mdfTickete.Currency);
            comando.Parameters.AddWithValue("@pTicketState", mdfTickete.TicketState);
            comando.Parameters.AddWithValue("@pIdClient", mdfTickete.IdClient);
            comando.Parameters.AddWithValue("@pIdFlight", mdfTickete.IdFlight);
            comando.Parameters.AddWithValue("@pNumSeat", mdfTickete.NumSeat);
            try
            {
                conexion.Open();
                tq = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();

        }
    }
}
