namespace Cuestionario_def1
{
    partial class FormFactura
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
            this.buttoncancelarseleccionado = new System.Windows.Forms.Button();
            this.buttonaceptarseleccionado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2fecha = new System.Windows.Forms.Label();
            this.textBoxbuscarcedula = new System.Windows.Forms.TextBox();
            this.label1cedula = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncancelarseleccionado
            // 
            this.buttoncancelarseleccionado.Location = new System.Drawing.Point(475, 399);
            this.buttoncancelarseleccionado.Name = "buttoncancelarseleccionado";
            this.buttoncancelarseleccionado.Size = new System.Drawing.Size(133, 27);
            this.buttoncancelarseleccionado.TabIndex = 15;
            this.buttoncancelarseleccionado.Text = "Cancelar";
            this.buttoncancelarseleccionado.UseVisualStyleBackColor = true;
            this.buttoncancelarseleccionado.Click += new System.EventHandler(this.buttoncancelarseleccionado_Click);
            // 
            // buttonaceptarseleccionado
            // 
            this.buttonaceptarseleccionado.Location = new System.Drawing.Point(226, 398);
            this.buttonaceptarseleccionado.Name = "buttonaceptarseleccionado";
            this.buttonaceptarseleccionado.Size = new System.Drawing.Size(130, 28);
            this.buttonaceptarseleccionado.TabIndex = 14;
            this.buttonaceptarseleccionado.Text = "Generar Factura";
            this.buttonaceptarseleccionado.UseVisualStyleBackColor = true;
            this.buttonaceptarseleccionado.Click += new System.EventHandler(this.buttonaceptarseleccionado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 205);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2fecha
            // 
            this.label2fecha.AutoSize = true;
            this.label2fecha.Location = new System.Drawing.Point(223, 77);
            this.label2fecha.Name = "label2fecha";
            this.label2fecha.Size = new System.Drawing.Size(97, 13);
            this.label2fecha.TabIndex = 11;
            this.label2fecha.Text = "Fecha de Creación";
            // 
            // textBoxbuscarcedula
            // 
            this.textBoxbuscarcedula.Location = new System.Drawing.Point(346, 28);
            this.textBoxbuscarcedula.Name = "textBoxbuscarcedula";
            this.textBoxbuscarcedula.Size = new System.Drawing.Size(121, 20);
            this.textBoxbuscarcedula.TabIndex = 10;
            this.textBoxbuscarcedula.TextChanged += new System.EventHandler(this.textBoxbuscarcedula_TextChanged);
            this.textBoxbuscarcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbuscarcedula_KeyPress);
            // 
            // label1cedula
            // 
            this.label1cedula.AutoSize = true;
            this.label1cedula.Location = new System.Drawing.Point(223, 28);
            this.label1cedula.Name = "label1cedula";
            this.label1cedula.Size = new System.Drawing.Size(90, 13);
            this.label1cedula.TabIndex = 9;
            this.label1cedula.Text = "Cédula de Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Facturas Pendientes de pago";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttoncancelarseleccionado);
            this.Controls.Add(this.buttonaceptarseleccionado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2fecha);
            this.Controls.Add(this.textBoxbuscarcedula);
            this.Controls.Add(this.label1cedula);
            this.Controls.Add(this.button1);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncancelarseleccionado;
        private System.Windows.Forms.Button buttonaceptarseleccionado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2fecha;
        private System.Windows.Forms.TextBox textBoxbuscarcedula;
        private System.Windows.Forms.Label label1cedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}