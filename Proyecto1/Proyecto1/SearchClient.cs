using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto1

{
    public partial class SearchClient : Form
    {

        

        public SearchClient()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             CD_PROYECTO.MyConnection con = new CD_PROYECTO.MyConnection();
            SqlConnection conexion = con.CreateConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login ingreso = new login();

            ingreso.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registro = new register();
            registro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tickets tiquetes = new tickets();
            tiquetes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flights vuelos = new flights();
            vuelos.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarClientes();           
             
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            
        }

        private void cargarClientes()
        {
            CD_PROYECTO.MyConnection con = new CD_PROYECTO.MyConnection();
            SqlConnection conexion = con.CreateConnection();
            
            conexion.Open();
            SqlDataAdapter daClients = new SqlDataAdapter("sp_listClients",conexion);
            DataSet dsClients = new DataSet();
            daClients.Fill(dsClients, "Clients");
            dgv.DataSource = dsClients;
            dgv.DataMember = "Clients";

              conexion.Close();
        
        }
    }
}
