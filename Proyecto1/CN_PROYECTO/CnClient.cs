using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN_PROYECTO
{
   public class CnClient
    {
               
        #region Variables

        private string id;
        private string name;
        private string lastname;
        private string email;
        private string phone;
        private string clientState ;

      
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

        public void GuardarCliente(CnClient client) {

            CD_PROYECTO.CdClient cl = new CD_PROYECTO.CdClient();
            cl.Id = client.Id;
            cl.Name = client.Name;
            cl.Lastname = client.Lastname;
            cl.Email = client.Email;
            cl.Phone = client.Phone;
            cl.ClientState = client.ClientState;
            cl.ClientType = client.clientType;
            cl.GuardarCliente(cl);
        }

        public void ModifyCliente(CnClient modify)
        {

            CD_PROYECTO.CdClient mdf = new CD_PROYECTO.CdClient();
            mdf.Id = modify.Id;
            mdf.Name = modify.Name;
            mdf.Lastname = modify.Lastname;
            mdf.Email = modify.Email;
            mdf.Phone = modify.Phone;
            mdf.ClientState = modify.ClientState;
            mdf.ClientType = modify.clientType;
            mdf.ModifyCliente(mdf);
        }

        #endregion
    }
        
    }
