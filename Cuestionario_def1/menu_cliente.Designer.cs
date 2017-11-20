namespace Cuestionario_def1
{
    partial class menu_cliente
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
            this.button1_Buscarcuestionario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Buscarcuestionario
            // 
            this.button1_Buscarcuestionario.Location = new System.Drawing.Point(51, 55);
            this.button1_Buscarcuestionario.Name = "button1_Buscarcuestionario";
            this.button1_Buscarcuestionario.Size = new System.Drawing.Size(228, 64);
            this.button1_Buscarcuestionario.TabIndex = 6;
            this.button1_Buscarcuestionario.Text = "Buscar Cuestionario";
            this.button1_Buscarcuestionario.UseVisualStyleBackColor = true;
            this.button1_Buscarcuestionario.Click += new System.EventHandler(this.button1_Buscarcuestionario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // menu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_Buscarcuestionario);
            this.Name = "menu_cliente";
            this.Text = "menu_cliente";
            this.Load += new System.EventHandler(this.menu_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_Buscarcuestionario;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}