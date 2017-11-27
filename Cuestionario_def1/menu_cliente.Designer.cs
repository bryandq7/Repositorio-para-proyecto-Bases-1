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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Buscarcuestionario
            // 
            this.button1_Buscarcuestionario.Location = new System.Drawing.Point(96, 65);
            this.button1_Buscarcuestionario.Name = "button1_Buscarcuestionario";
            this.button1_Buscarcuestionario.Size = new System.Drawing.Size(141, 47);
            this.button1_Buscarcuestionario.TabIndex = 6;
            this.button1_Buscarcuestionario.Text = "Buscar Cuestionario";
            this.button1_Buscarcuestionario.UseVisualStyleBackColor = true;
            this.button1_Buscarcuestionario.Click += new System.EventHandler(this.button1_Buscarcuestionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menú Encuestado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar datos y buscar Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Buscarcuestionario);
            this.Name = "menu_cliente";
            this.Text = "menu_cliente";
            this.Load += new System.EventHandler(this.menu_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_Buscarcuestionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}