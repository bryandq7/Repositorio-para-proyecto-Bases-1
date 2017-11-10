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
    public partial class Diseño_de_pregunta : Form
    {
        Adaptador cbx = new Adaptador();
        public Diseño_de_pregunta()
        {
            InitializeComponent();
        }

        private void Diseño_de_pregunta_Load(object sender, EventArgs e)
        {
            cbx.llenarComboBox_tipo_pregunta(comboBoxtipo_pregunta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuestionario _verCuestionario = new Cuestionario();

        }
    }
}
