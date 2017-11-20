namespace Cuestionario_def1
{
    partial class Responder_cuestionario
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
            this.textBoxbuscarapellido1 = new System.Windows.Forms.TextBox();
            this.label2_Nombre_creador = new System.Windows.Forms.Label();
            this.textBoxbuscarnombre = new System.Windows.Forms.TextBox();
            this.label1Nombre_cuestionario = new System.Windows.Forms.Label();
            this.button2buscarcuestionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncancelarseleccionado
            // 
            this.buttoncancelarseleccionado.Location = new System.Drawing.Point(451, 359);
            this.buttoncancelarseleccionado.Name = "buttoncancelarseleccionado";
            this.buttoncancelarseleccionado.Size = new System.Drawing.Size(133, 27);
            this.buttoncancelarseleccionado.TabIndex = 15;
            this.buttoncancelarseleccionado.Text = "Cancelar";
            this.buttoncancelarseleccionado.UseVisualStyleBackColor = true;
            // 
            // buttonaceptarseleccionado
            // 
            this.buttonaceptarseleccionado.Location = new System.Drawing.Point(202, 358);
            this.buttonaceptarseleccionado.Name = "buttonaceptarseleccionado";
            this.buttonaceptarseleccionado.Size = new System.Drawing.Size(130, 28);
            this.buttonaceptarseleccionado.TabIndex = 14;
            this.buttonaceptarseleccionado.Text = "Aceptar";
            this.buttonaceptarseleccionado.UseVisualStyleBackColor = true;
            this.buttonaceptarseleccionado.Click += new System.EventHandler(this.buttonaceptarseleccionado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 172);
            this.dataGridView1.TabIndex = 13;
            // 
            // textBoxbuscarapellido1
            // 
            this.textBoxbuscarapellido1.Location = new System.Drawing.Point(280, 74);
            this.textBoxbuscarapellido1.Name = "textBoxbuscarapellido1";
            this.textBoxbuscarapellido1.Size = new System.Drawing.Size(121, 20);
            this.textBoxbuscarapellido1.TabIndex = 12;
            // 
            // label2_Nombre_creador
            // 
            this.label2_Nombre_creador.AutoSize = true;
            this.label2_Nombre_creador.Location = new System.Drawing.Point(139, 77);
            this.label2_Nombre_creador.Name = "label2_Nombre_creador";
            this.label2_Nombre_creador.Size = new System.Drawing.Size(84, 13);
            this.label2_Nombre_creador.TabIndex = 11;
            this.label2_Nombre_creador.Text = "Nombre Creador";
            // 
            // textBoxbuscarnombre
            // 
            this.textBoxbuscarnombre.Location = new System.Drawing.Point(280, 32);
            this.textBoxbuscarnombre.Name = "textBoxbuscarnombre";
            this.textBoxbuscarnombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxbuscarnombre.TabIndex = 10;
            // 
            // label1Nombre_cuestionario
            // 
            this.label1Nombre_cuestionario.AutoSize = true;
            this.label1Nombre_cuestionario.Location = new System.Drawing.Point(139, 35);
            this.label1Nombre_cuestionario.Name = "label1Nombre_cuestionario";
            this.label1Nombre_cuestionario.Size = new System.Drawing.Size(105, 13);
            this.label1Nombre_cuestionario.TabIndex = 9;
            this.label1Nombre_cuestionario.Text = "Nombre Cuestionario";
            // 
            // button2buscarcuestionario
            // 
            this.button2buscarcuestionario.Location = new System.Drawing.Point(488, 48);
            this.button2buscarcuestionario.Name = "button2buscarcuestionario";
            this.button2buscarcuestionario.Size = new System.Drawing.Size(130, 28);
            this.button2buscarcuestionario.TabIndex = 17;
            this.button2buscarcuestionario.Text = "Buscar";
            this.button2buscarcuestionario.UseVisualStyleBackColor = true;
            this.button2buscarcuestionario.Click += new System.EventHandler(this.button2buscarcuestionario_Click);
            // 
            // Responder_cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 442);
            this.Controls.Add(this.button2buscarcuestionario);
            this.Controls.Add(this.buttoncancelarseleccionado);
            this.Controls.Add(this.buttonaceptarseleccionado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxbuscarapellido1);
            this.Controls.Add(this.label2_Nombre_creador);
            this.Controls.Add(this.textBoxbuscarnombre);
            this.Controls.Add(this.label1Nombre_cuestionario);
            this.Name = "Responder_cuestionario";
            this.Text = "Responder_cuestionario";
            this.Load += new System.EventHandler(this.Responder_cuestionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncancelarseleccionado;
        private System.Windows.Forms.Button buttonaceptarseleccionado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxbuscarapellido1;
        private System.Windows.Forms.Label label2_Nombre_creador;
        private System.Windows.Forms.TextBox textBoxbuscarnombre;
        private System.Windows.Forms.Label label1Nombre_cuestionario;
        private System.Windows.Forms.Button button2buscarcuestionario;
    }
}