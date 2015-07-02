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
    public partial class tickets : Form
    {
        public tickets()
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

        private void button1_Click(object sender, EventArgs e)
        {
            login ingreso = new login();

            ingreso.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchTicket busquedaTiquete = new searchTicket();
            busquedaTiquete.Show();
            this.Hide();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            //CN_PROYECTO.CnTicket ticket = new CN_PROYECTO.CnTicket();
            //ticket.IdFlight = txtticket.Text;
            //ticket.IdClient = txtIdclient.Text;
            //ticket.Price = double.Parse(txtprice.Text);
            //if (ckactivo.CheckState == CheckState.Checked)
            //{
            //    ticket.TicketState = "Activo";
            //}
            //else
            //{
            //    ticket.TicketState = "Inactivo";
            //}

            //if (ckdolares.CheckState == CheckState.Checked)
            //{
            //    ticket.Currency = 1;
            //}
            //else
            //{
            //    ticket.Currency = 2;
            //}

            //ticket.IdFlight = txtflight.Text;

            //ticket.GuardarTickete(ticket);

            //MessageBox.Show("TICKETE REGISTRADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //lblMsj.Text = " REGISTRADO EN BD";


            //limpiarTextBox();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //CN_PROYECTO.CnClient clientMDF = new CN_PROYECTO.CnClient();


            //CN_PROYECTO.CnTicket ticket = new CN_PROYECTO.CnTicket();
            //ticket.IdFlight = txtticket.Text;
            //ticket.IdClient = txtIdclient.Text;
            //ticket.Price = double.Parse(txtprice.Text);
            //if (ckactivo.CheckState == CheckState.Checked)
            //{
            //    ticket.TicketState = "Activo";
            //}
            //else
            //{
            //    ticket.TicketState = "Inactivo";
            //}

            //if (ckdolares.CheckState == CheckState.Checked)
            //{
            //    ticket.Currency = 1;
            //}
            //else
            //{
            //    ticket.Currency = 2;
            //}

            //ticket.IdFlight = txtflight.Text;

            //ticket.ModifyTickete(ticket);

            //MessageBox.Show("TICKETE MODIFICADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //lblMsj.Text = " MODIFICADO EN BD";


            //limpiarTextBox();

        }
        public void limpiarTextBox()
        {

            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";

                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tickets_Load(object sender, EventArgs e)
        {

        }
    }

}
