using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CD_PROYECTO
{
    public class CdPlane
    {
        private int idPlane;
        private int qtyAsiento;
        private String marca;
        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }        

        public int QtyAsiento
        {
            get { return qtyAsiento; }
            set { qtyAsiento = value; }
        }
        public List<CdPlane> ListarAvion()
        {
            List<CdPlane> listaavion = new List<CdPlane>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader pl;

            comando.CommandText = "sp_listPlane";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                pl = comando.ExecuteReader();
                while (pl.Read())
                {
                    CdPlane creaavion = new CdPlane();
                    creaavion.IdPlane = (int)pl["ID"];
                    creaavion.Marca = (string)pl["Marca"];
                    creaavion.QtyAsiento = (int)pl["CantidadAsientos"];

                    listaavion.Add(creaavion);

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return listaavion;
        }


    }
}
