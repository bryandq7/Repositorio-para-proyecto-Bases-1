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
    public partial class FormFactura : Form
    {
        public int idfactura;
        public string cliente;
        public List<Factura> Facturaseleccionada = new List<Factura>();
        int num_cuestionario = 0;

        public FormFactura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = Factura_contr.Buscar(Convert.ToInt32(textBoxbuscarcedula.Text), 
            dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day);


        }

        private void buttonaceptarseleccionado_Click(object sender, EventArgs e)
        {


            Facturaseleccionada = Factura_contr.Buscar(Convert.ToInt32(textBoxbuscarcedula.Text),
            dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day);


            if (Facturaseleccionada != null)
            {

                for (int i = 0; i < Facturaseleccionada.Count; i++)
                {
                    num_cuestionario = num_cuestionario + 1;

                    DateTime fechaActual = DateTime.Today;
                    int resultado = 0;
                    Factura pFactura = new Factura();
                    pFactura.activo = Convert.ToInt32(1);
                    pFactura.cantidad_preguntas = Facturaseleccionada[i].cantidad_preguntas;
                    pFactura.precio = 2500;
                    pFactura.sub_total = (Facturaseleccionada[i].cantidad_preguntas) * pFactura.precio;
                    pFactura.Nombre_cuestionario = Facturaseleccionada[i].Nombre_cuestionario;
                    pFactura.Fecha_creacion = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                    pFactura.monto_total = 0;
                    pFactura.cedula = Facturaseleccionada[i].cedula;
                    pFactura.idCuestionario = Facturaseleccionada[i].idCuestionario;

                    idfactura= Facturaseleccionada[0].idFactura;
                    cliente = Facturaseleccionada[0].Nombre_creador + " " + Facturaseleccionada[0].Apellid1_creador + " " + Facturaseleccionada[0].Apellido2_creador;
                    resultado = Factura_contr.Agregar(pFactura, num_cuestionario);
                }

                Form_pagar_factura frmp = new Form_pagar_factura();

                frmp.id_factura = Factura_contr.BuscarIdFactura();
                frmp.cliente = cliente;
                frmp.ShowDialog();


            }
                
            this.Close();
        }
    }
}
