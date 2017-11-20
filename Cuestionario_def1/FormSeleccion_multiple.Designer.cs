namespace Cuestionario_def1
{
    partial class FormSeleccion_multiple
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
            this.label_pregunta = new System.Windows.Forms.Label();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1_nombre_cuestionario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_pregunta
            // 
            this.label_pregunta.AutoSize = true;
            this.label_pregunta.Location = new System.Drawing.Point(94, 63);
            this.label_pregunta.Name = "label_pregunta";
            this.label_pregunta.Size = new System.Drawing.Size(35, 13);
            this.label_pregunta.TabIndex = 13;
            this.label_pregunta.Text = "label1";
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Location = new System.Drawing.Point(559, 330);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(126, 42);
            this.button_Siguiente.TabIndex = 12;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(97, 299);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(97, 237);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(97, 175);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1_nombre_cuestionario
            // 
            this.label1_nombre_cuestionario.AutoSize = true;
            this.label1_nombre_cuestionario.Location = new System.Drawing.Point(64, 28);
            this.label1_nombre_cuestionario.Name = "label1_nombre_cuestionario";
            this.label1_nombre_cuestionario.Size = new System.Drawing.Size(35, 13);
            this.label1_nombre_cuestionario.TabIndex = 7;
            this.label1_nombre_cuestionario.Text = "label1";
            // 
            // FormSeleccion_multiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 401);
            this.Controls.Add(this.label_pregunta);
            this.Controls.Add(this.button_Siguiente);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1_nombre_cuestionario);
            this.Name = "FormSeleccion_multiple";
            this.Text = "FormSeleccion_multiple";
            this.Load += new System.EventHandler(this.FormSeleccion_multiple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pregunta;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1_nombre_cuestionario;
    }
}