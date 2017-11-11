namespace Cuestionario_def1
{
    partial class Diseño_cuestionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre_cuestionario = new System.Windows.Forms.TextBox();
            this.textBox_cant_preguntas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Cuestionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombre_cuestionario
            // 
            this.textBoxNombre_cuestionario.Location = new System.Drawing.Point(249, 38);
            this.textBoxNombre_cuestionario.Name = "textBoxNombre_cuestionario";
            this.textBoxNombre_cuestionario.Size = new System.Drawing.Size(109, 20);
            this.textBoxNombre_cuestionario.TabIndex = 2;
            this.textBoxNombre_cuestionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_cant_preguntas
            // 
            this.textBox_cant_preguntas.Location = new System.Drawing.Point(249, 89);
            this.textBox_cant_preguntas.Name = "textBox_cant_preguntas";
            this.textBox_cant_preguntas.Size = new System.Drawing.Size(109, 20);
            this.textBox_cant_preguntas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Preguntas del Cuestionario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Diseño_cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_cant_preguntas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre_cuestionario);
            this.Controls.Add(this.label1);
            this.Name = "Diseño_cuestionario";
            this.Text = "Diseño_cuestionario";
            this.Load += new System.EventHandler(this.Diseño_cuestionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre_cuestionario;
        private System.Windows.Forms.TextBox textBox_cant_preguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}