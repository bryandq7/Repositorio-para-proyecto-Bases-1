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
        public Form_pagar_factura()
        {
            InitializeComponent();
        }

        private void Form_pagar_factura_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Factura_contr.ObtenerFactura(id_factura);
            label2cliente.Text = cliente;
            labelnumfactura.Text = id_factura.ToString();
            textBox1monto_pagar.Text = Factura_contr.Buscar_monto_Factura(Factura_contr.BuscarIdFactura()).ToString();
        }

        private void button1pagar_Click(object sender, EventArgs e)
        {
            Factura_contr.Pagar_factura(Factura_contr.BuscarIdFactura());
            MessageBox.Show("Su pago ha resultado exitoso", "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
