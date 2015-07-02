using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class flights : Form
    {
        public flights()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flights vuelos = new flights();
            vuelos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tickets tiquetes = new tickets();
            tiquetes.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            register registro = new register();
            registro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login ingreso = new login();

            ingreso.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchFlights busquedaVuelos = new searchFlights();
            busquedaVuelos.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flights_Load(object sender, EventArgs e)
        {
            CN_PROYECTO.CnPlane p = new CN_PROYECTO.CnPlane();
            bindingSourcePlanes.DataSource = p.ListarAviones();

            cboPlanes.DataSource = bindingSourcePlanes.DataSource;
            cboPlanes.DisplayMember = "Marca";
            cboPlanes.ValueMember = "IdPlane";
        }

        private void cboPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CN_PROYECTO.CnFlight f = new CN_PROYECTO.CnFlight();
            f.IdPlane = (int)cboPlanes.SelectedValue;
        }
    }
}
