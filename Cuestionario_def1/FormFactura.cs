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
        public List<int> arreglo_ids_cuestionarios = new List<int>();
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
            int contador = 0;
            if (textBoxbuscarcedula.Text=="")
            {
                contador = 1;
            }

            if (contador == 0)
            {


            dataGridView1.DataSource = Factura_contr.Buscar(Convert.ToInt32(textBoxbuscarcedula.Text), 
            dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day);

            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
            this.dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[0].HeaderText= "Nombre Cuestionario";
            dataGridView1.Columns[2].HeaderText = "Cantidad de preguntas";
            dataGridView1.Columns[3].HeaderText = "Fecha de Creación";
            dataGridView1.Columns[4].HeaderText = "Número de cuestionario";
            dataGridView1.Columns[6].HeaderText = "Nombre Creador";
            dataGridView1.Columns[7].HeaderText = "Apellido 1 del creador";
            dataGridView1.Columns[8].HeaderText = "Apellido 2 del creador";
            dataGridView1.Columns[9].HeaderText = "Cédula Creador";


            dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[2].DisplayIndex = 2;
            dataGridView1.Columns[3].DisplayIndex = 3;
            dataGridView1.Columns[4].DisplayIndex = 1;
            dataGridView1.Columns[6].DisplayIndex = 5;
            dataGridView1.Columns[7].DisplayIndex = 6;
            dataGridView1.Columns[8].DisplayIndex = 7;
            dataGridView1.Columns[9].DisplayIndex = 4;

                textBoxbuscarcedula.Enabled = false;
            

            }


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

                    arreglo_ids_cuestionarios.Add(Facturaseleccionada[i].idCuestionario);
                }

                Form_pagar_factura frmp = new Form_pagar_factura();

                frmp.id_factura = Factura_contr.BuscarIdFactura();

                frmp.arreglo_ids_cuestionarios2 = arreglo_ids_cuestionarios;


                frmp.cliente = cliente;
                frmp.ShowDialog();

                }
            
                
            this.Close();
        }

        private void buttoncancelarseleccionado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxbuscarcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBoxbuscarcedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
