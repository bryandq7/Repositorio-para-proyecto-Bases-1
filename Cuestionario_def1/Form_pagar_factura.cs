using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuestionario_def1
{
    public partial class Form_pagar_factura : Form
    {
        public int id_factura;
        public string cliente;
        public List<int> arreglo_ids_cuestionarios2 = new List<int>();
        public Form_pagar_factura()
        {
            InitializeComponent();
        }

        private void Form_pagar_factura_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Factura_contr.ObtenerFactura(id_factura);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[2].HeaderText = "Cantidad de preguntas";
            dataGridView1.Columns[3].HeaderText = "Fecha de Creación";
            dataGridView1.Columns[4].HeaderText =  "Número de cuestionario";
            dataGridView1.Columns[11].HeaderText = "Sub Total";
            dataGridView1.Columns[12].HeaderText = "Precio";
            dataGridView1.Columns[13].HeaderText = "Número de factura";
            dataGridView1.Columns[14].HeaderText = "Número de Linea";
            dataGridView1.Columns[15].HeaderText = "Nombre de Cuestionario";



            dataGridView1.Columns[2].DisplayIndex = 5;
            dataGridView1.Columns[3].DisplayIndex = 4;
            dataGridView1.Columns[4].DisplayIndex = 0;
            dataGridView1.Columns[11].DisplayIndex = 7;
            dataGridView1.Columns[12].DisplayIndex = 6;
            dataGridView1.Columns[13].DisplayIndex = 2;
            dataGridView1.Columns[14].DisplayIndex = 3;
            dataGridView1.Columns[15].DisplayIndex = 1;

            label2cliente.Text = cliente;
            labelnumfactura.Text = id_factura.ToString();
            textBox1monto_pagar.Text = Factura_contr.Buscar_monto_Factura(Factura_contr.BuscarIdFactura()).ToString();
        }

        private void button1pagar_Click(object sender, EventArgs e)
        {
            Factura_contr.Pagar_factura(Factura_contr.BuscarIdFactura());

            for (int i = 0; i < arreglo_ids_cuestionarios2.Count; i++)
            {
                Factura_contr.Pagar_Cuestionario(arreglo_ids_cuestionarios2[i]);
            }
            MessageBox.Show("Su pago ha resultado exitoso", "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
