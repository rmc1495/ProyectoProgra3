namespace Proyecto1
{
    partial class tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscarCliente = new System.Windows.Forms.TextBox();
            this.txtbuxcarVuelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Proyecto1.Properties.Resources.proyecto_sitemaBOTONES_04;
            this.button4.Location = new System.Drawing.Point(376, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 29);
            this.button4.TabIndex = 51;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Proyecto1.Properties.Resources.proyecto_sitemaBOTONES_03;
            this.button3.Location = new System.Drawing.Point(253, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 29);
            this.button3.TabIndex = 50;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Proyecto1.Properties.Resources.proyecto_sitemaBOTONES_02;
            this.button2.Location = new System.Drawing.Point(127, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Proyecto1.Properties.Resources.proyecto_sitemaBOTONES_01;
            this.button1.Location = new System.Drawing.Point(1, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(459, 169);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(0, 13);
            this.lblMsj.TabIndex = 52;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(25, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 162);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID CLIENTE";
            // 
            // txtbuscarCliente
            // 
            this.txtbuscarCliente.Location = new System.Drawing.Point(61, 161);
            this.txtbuscarCliente.Name = "txtbuscarCliente";
            this.txtbuscarCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarCliente.TabIndex = 55;
            // 
            // txtbuxcarVuelo
            // 
            this.txtbuxcarVuelo.Location = new System.Drawing.Point(194, 161);
            this.txtbuxcarVuelo.Name = "txtbuxcarVuelo";
            this.txtbuxcarVuelo.Size = new System.Drawing.Size(100, 20);
            this.txtbuxcarVuelo.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID VUELO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(333, 158);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1.Properties.Resources.proyecto_sitemas_tickets;
            this.ClientSize = new System.Drawing.Size(784, 464);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuxcarVuelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tickets";
            this.Load += new System.EventHandler(this.tickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscarCliente;
        private System.Windows.Forms.TextBox txtbuxcarVuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
    }
}