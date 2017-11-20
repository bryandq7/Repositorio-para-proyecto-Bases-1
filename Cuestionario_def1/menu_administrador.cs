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
    public partial class menu_administrador : Form
    {
        public string sUsuario;
        public menu_administrador()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso_persona frm = new ingreso_persona();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Diseño_cuestionario frm1 = new Diseño_cuestionario();
            frm1.sUsuario = sUsuario;
            frm1.Show();
        }

        private void menu_administrador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFactura frmfc = new FormFactura();
            frmfc.ShowDialog();

        }
    }
}
