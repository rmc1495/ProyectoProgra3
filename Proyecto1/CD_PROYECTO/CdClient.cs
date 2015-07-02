using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CD_PROYECTO
{
    /// <summary>
    /// CLASE CREADA POR LUIS ROBERTO MORA CASTRO 14-06-2015
    /// </summary>
    public class CdClient:MyConnection
    {

        #region Procedimientos Almacenados
        const string GUARDAR_Cliente = "sp_Register";
        const string Modify_Cliente = "sp_UpdateClient";
        #endregion
        #region Variables

        private string id;
        private string name;
        private string lastname;
        private string email;
        private string phone;
        private string clientState;
        private string clientType;

       
        #endregion


        #region Properties 
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string ClientState
        {
            get { return clientState; }
            set { clientState = value; }
        }

        public string ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }
        
        #endregion

        
        #region Metodos


        public void GuardarCliente(CdClient persona) {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cliente;

            comando.CommandText = GUARDAR_Cliente;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@pId", persona.Id));
            comando.Parameters.Add(new SqlParameter("@pName ", persona.Name));
            comando.Parameters.Add(new SqlParameter("@pLastname", persona.Lastname));
            //comando.Parameters.Add(new SqlParameter("@pAapellido2", persona.Apellido2));
            comando.Parameters.Add(new SqlParameter("@pEmail", persona.Email));
            comando.Parameters.Add(new SqlParameter("@pPhone", persona.Phone));
            comando.Parameters.Add(new SqlParameter("@pClientState", persona.ClientState));
            comando.Parameters.Add(new SqlParameter("@pClientType", persona.ClientType));
            conexion.Open();
            cliente = comando.ExecuteReader();
            conexion.Close();
             
        }


        public void ModifyCliente(CdClient mdfPersona)
        {

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cliente;

            comando.CommandText = Modify_Cliente;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@pId", mdfPersona.Id));
            comando.Parameters.Add(new SqlParameter("@pName ", mdfPersona.Name));
            comando.Parameters.Add(new SqlParameter("@pLastname", mdfPersona.Lastname));
            
            comando.Parameters.Add(new SqlParameter("@pEmail", mdfPersona.Email));
            comando.Parameters.Add(new SqlParameter("@pPhone", mdfPersona.Phone));
            comando.Parameters.Add(new SqlParameter("@pClientState", mdfPersona.ClientState));
            comando.Parameters.Add(new SqlParameter("@pClientType", mdfPersona.ClientType));
            conexion.Open();
            cliente = comando.ExecuteReader();
            conexion.Close();

        }



        #endregion
    }
}
