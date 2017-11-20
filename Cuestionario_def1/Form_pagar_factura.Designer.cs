namespace Cuestionario_def1
{
    partial class Form_pagar_factura
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
            this.label2cliente = new System.Windows.Forms.Label();
            this.label2n = new System.Windows.Forms.Label();
            this.labelnumfactura = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1monto_pagar = new System.Windows.Forms.TextBox();
            this.button1pagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2cliente
            // 
            this.label2cliente.AutoSize = true;
            this.label2cliente.Location = new System.Drawing.Point(119, 39);
            this.label2cliente.Name = "label2cliente";
            this.label2cliente.Size = new System.Drawing.Size(35, 13);
            this.label2cliente.TabIndex = 1;
            this.label2cliente.Text = "label2";
            // 
            // label2n
            // 
            this.label2n.AutoSize = true;
            this.label2n.Location = new System.Drawing.Point(58, 85);
            this.label2n.Name = "label2n";
            this.label2n.Size = new System.Drawing.Size(101, 13);
            this.label2n.TabIndex = 2;
            this.label2n.Text = "Número de Factura:";
            // 
            // labelnumfactura
            // 
            this.labelnumfactura.AutoSize = true;
            this.labelnumfactura.Location = new System.Drawing.Point(178, 85);
            this.labelnumfactura.Name = "labelnumfactura";
            this.labelnumfactura.Size = new System.Drawing.Size(35, 13);
            this.labelnumfactura.TabIndex = 3;
            this.labelnumfactura.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 183);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto a Pagar:";
            // 
            // textBox1monto_pagar
            // 
            this.textBox1monto_pagar.Location = new System.Drawing.Point(496, 339);
            this.textBox1monto_pagar.Name = "textBox1monto_pagar";
            this.textBox1monto_pagar.Size = new System.Drawing.Size(103, 20);
            this.textBox1monto_pagar.TabIndex = 6;
            // 
            // button1pagar
            // 
            this.button1pagar.Location = new System.Drawing.Point(618, 385);
            this.button1pagar.Name = "button1pagar";
            this.button1pagar.Size = new System.Drawing.Size(131, 23);
            this.button1pagar.TabIndex = 7;
            this.button1pagar.Text = "Pagar";
            this.button1pagar.UseVisualStyleBackColor = true;
            this.button1pagar.Click += new System.EventHandler(this.button1pagar_Click);
            // 
            // Form_pagar_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 418);
            this.Controls.Add(this.button1pagar);
            this.Controls.Add(this.textBox1monto_pagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelnumfactura);
            this.Controls.Add(this.label2n);
            this.Controls.Add(this.label2cliente);
            this.Controls.Add(this.label1);
            this.Name = "Form_pagar_factura";
            this.Text = "Form_pagar_factura";
            this.Load += new System.EventHandler(this.Form_pagar_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2cliente;
        private System.Windows.Forms.Label label2n;
        private System.Windows.Forms.Label labelnumfactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1monto_pagar;
        private System.Windows.Forms.Button button1pagar;
    }
}