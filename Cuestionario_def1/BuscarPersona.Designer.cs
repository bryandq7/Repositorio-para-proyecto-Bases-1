namespace Cuestionario_def1
{
    partial class BuscarPersona
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxbuscarnombre = new System.Windows.Forms.TextBox();
            this.textBoxbuscarapellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonaceptarseleccionado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxbuscarnombre
            // 
            this.textBoxbuscarnombre.Location = new System.Drawing.Point(284, 31);
            this.textBoxbuscarnombre.Name = "textBoxbuscarnombre";
            this.textBoxbuscarnombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxbuscarnombre.TabIndex = 2;
            // 
            // textBoxbuscarapellido1
            // 
            this.textBoxbuscarapellido1.Location = new System.Drawing.Point(284, 73);
            this.textBoxbuscarapellido1.Name = "textBoxbuscarapellido1";
            this.textBoxbuscarapellido1.Size = new System.Drawing.Size(121, 20);
            this.textBoxbuscarapellido1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 172);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonaceptarseleccionado
            // 
            this.buttonaceptarseleccionado.Location = new System.Drawing.Point(294, 370);
            this.buttonaceptarseleccionado.Name = "buttonaceptarseleccionado";
            this.buttonaceptarseleccionado.Size = new System.Drawing.Size(130, 39);
            this.buttonaceptarseleccionado.TabIndex = 6;
            this.buttonaceptarseleccionado.Text = "Aceptar";
            this.buttonaceptarseleccionado.UseVisualStyleBackColor = true;
            this.buttonaceptarseleccionado.Click += new System.EventHandler(this.buttonaceptarseleccionado_Click);
            // 
            // BuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 446);
            this.Controls.Add(this.buttonaceptarseleccionado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxbuscarapellido1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxbuscarnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BuscarPersona";
            this.Text = "BuscarPersona";
            this.Load += new System.EventHandler(this.BuscarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxbuscarnombre;
        private System.Windows.Forms.TextBox textBoxbuscarapellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonaceptarseleccionado;
    }
}