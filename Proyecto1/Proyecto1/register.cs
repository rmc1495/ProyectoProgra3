using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
             
            cmbType.Items.Add("Regular");
            cmbType.Items.Add("Platino");
            cmbType.Items.Add("Diamante");

            cmbState.Items.Add("Soltero");
            cmbState.Items.Add("Casado");
            cmbState.Items.Add("Divorciado");
            cmbState.Items.Add("Viudo");
            cmbState.Items.Add("Union Libre");
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            CD_PROYECTO.MyConnection con = new CD_PROYECTO.MyConnection();


            SqlConnection conexion = con.CreateConnection();
            SqlCommand commando = con.CreateCommand(conexion);
            SqlDataReader leer;
            commando.CommandText = "sp_searchById";
            commando.CommandType = CommandType.StoredProcedure;
            commando.Parameters.Add(new SqlParameter("@pId", txtID.Text));
            conexion.Open();
            leer = commando.ExecuteReader();
            if (leer.Read() == true)
            {
                MessageBox.Show("Registro Encontrado");
                txtID.Text = leer["id"].ToString();
                txtName.Text = leer["name"].ToString();
                txtLastName.Text = leer["lastname"].ToString();
                txtEmail.Text = leer["email"].ToString();
                txtPhone.Text = leer["phone"].ToString();
                cmbState.Text = leer["clientState"].ToString();
                cmbType.Text = leer["clientType"].ToString();      
            }
            else
            {
                MessageBox.Show("Registro No Encontrado");
                txtID.Text = "";
                txtName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                
            }
            conexion.Close();
            
        }


        private void btnSearchAll(object sender, EventArgs e)
        {

            SearchClient busquedaCliente = new SearchClient();
            busquedaCliente.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            register registro = new register();
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

        public void limpiarTextBox() {

            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";

                    //Enfoco en el primer TextBox

                    this.txtID.Focus();
                    this.txtPhone.Text = "";
                     
                }

            }
        
        }     
        private void btnRegister_Click(object sender, EventArgs e)
        {
            CN_PROYECTO.CnClient client = new CN_PROYECTO.CnClient();

             
                client.Id = txtID.Text;
                client.Name = txtName.Text;
                client.Lastname = txtLastName.Text;
                //cliente.Apellido2 = textBox3.Text;
                client.Email = txtEmail.Text;
                client.Phone = txtPhone.Text;
                client.ClientState = cmbState.Text;        ///BUSCAR ESTE CHECKBOX
                client.ClientType = cmbType.Text;           /// BUSCAR ESTE COMBOBOX
                client.GuardarCliente(client);
                
                MessageBox.Show("USUARIO REGISTRADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMsj.Text = " REGISTRADO EN BD" ;
           
                                   
                limpiarTextBox();
                cmbType.SelectedIndex = -1;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e) //validacion solo letras
        {
            if (!(char.IsLetter(e.KeyChar))&&(e.KeyChar!=(char)Keys.Back))
            {
                 MessageBox.Show("Solo se permiten letras","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            
       } 
        

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
             
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchClient busquedaCliente = new SearchClient();
            busquedaCliente.Show();
            this.Hide();
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            CN_PROYECTO.CnClient clientMDF = new CN_PROYECTO.CnClient();


            clientMDF.Id = txtID.Text;
            clientMDF.Name = txtName.Text;
            clientMDF.Lastname = txtLastName.Text;
            //cliente.Apellido2 = textBox3.Text;
            clientMDF.Email = txtEmail.Text;
            clientMDF.Phone = txtPhone.Text;
             
            clientMDF.ClientState = cmbState.Text;        ///BUSCAR ESTE CHECKBOX
            clientMDF.ClientType = cmbType.Text;           /// BUSCAR ESTE COMBOBOX
            clientMDF.ModifyCliente(clientMDF);

            MessageBox.Show("USUARIO MODIFICADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMsj.Text = " MODIFICADO EN BD";


            limpiarTextBox();
            cmbType.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;
        }
    }
}
