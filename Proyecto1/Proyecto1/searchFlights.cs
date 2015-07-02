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
    public partial class searchFlights : Form
    {
        public searchFlights()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
