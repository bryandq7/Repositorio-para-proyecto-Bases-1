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
    public partial class ingreso_persona : Form
    {
        Adaptador cbx = new Adaptador();
        public Cliente Cliente_actual = new Cliente();
       
        
        public ingreso_persona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtoncliente.Checked)
            {
                Cliente pCliente = new Cliente();
                pCliente.Nombre1 = textBoxprimernombre.Text.Trim();
                pCliente.Nombre2 = textBoxsegundonombre.Text.Trim();
                pCliente.Apellido1 = textBoxprimerapellido.Text.Trim();
                pCliente.Apellido2 = textBoxsegundoapellido.Text.Trim();
                pCliente.Cedula = Convert.ToInt32(textBoxcedula.Text.Trim());
                pCliente.Fecha_Nac = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                pCliente.id_genero = Convert.ToInt32(comboBoxgenero.SelectedValue);
                pCliente.Numero_telefono = Convert.ToInt32(textBoxnumerotelefono.Text.Trim());
                pCliente.id_tipo_telefono = Convert.ToInt32(comboBoxtipotelefono.SelectedValue);
                pCliente.Correo_electronico = textBoxcorreoelectronico.Text.Trim();
                pCliente.id_tipo_correo = Convert.ToInt32(comboBoxtipocorreo.SelectedValue);
                pCliente.Usuario = textBoxusuario.Text.Trim();
                pCliente.Contrasena = textBoxcontrasena.Text.Trim();

                pCliente.id_tipo_usuario = Convert.ToInt32(1);
            
                pCliente.id_tipo_cliente = Convert.ToInt32(comboBoxtipocliente.SelectedValue);

                pCliente.activo = Convert.ToInt32(1);

                int resultado = Clientes_Contr.Agregar(pCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            if (radioButtonadministrador.Checked)
            {
                Administrador pAdmin = new Administrador();
                pAdmin.Nombre1 = textBoxprimernombre.Text.Trim();
                pAdmin.Nombre2 = textBoxsegundonombre.Text.Trim();
                pAdmin.Apellido1 = textBoxprimerapellido.Text.Trim();
                pAdmin.Apellido2 = textBoxsegundoapellido.Text.Trim();
                pAdmin.Cedula = Convert.ToInt32(textBoxcedula.Text.Trim());
                pAdmin.Fecha_Nac = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                pAdmin.id_genero = Convert.ToInt32(comboBoxgenero.SelectedValue);
                pAdmin.Numero_telefono = Convert.ToInt32(textBoxnumerotelefono.Text.Trim());
                pAdmin.id_tipo_telefono = Convert.ToInt32(comboBoxtipotelefono.SelectedValue);
                pAdmin.Correo_electronico = textBoxcorreoelectronico.Text.Trim();
                pAdmin.id_tipo_correo = Convert.ToInt32(comboBoxtipocorreo.SelectedValue);
                pAdmin.Usuario = textBoxusuario.Text.Trim();
                pAdmin.Contrasena = textBoxcontrasena.Text.Trim();

                pAdmin.Fecha_Ing = dateTimePicker2.Value.Year + "/" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Day;
                pAdmin.Salario = Convert.ToInt32(textBoxsalario.Text.Trim());

                pAdmin.id_tipo_usuario = Convert.ToInt32(2);

                pAdmin.id_tipo_cajero = Convert.ToInt32(comboBoxniveldepuesto.SelectedValue);

                pAdmin.activo = Convert.ToInt32(1);

                int resultado = Administrador_Contr.Agregar(pAdmin);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonactualizaringresopersonas_Click(object sender, EventArgs e)
        {
            cbx.llenarComboBox_genero(comboBoxgenero);
            cbx.llenarComboBox_tipo_Telefono(comboBoxtipotelefono);
            cbx.llenarComboBox_tipo_correo(comboBoxtipocorreo);
            cbx.llenarComboBox_Nivel_Puesto(comboBoxniveldepuesto);
            cbx.llenarComboBox_tipo_cliente(comboBoxtipocliente);


        }

        private void ingreso_persona_Load(object sender, EventArgs e)
        {
            cbx.llenarComboBox_genero(comboBoxgenero);
            cbx.llenarComboBox_tipo_Telefono(comboBoxtipotelefono);
            cbx.llenarComboBox_tipo_correo(comboBoxtipocorreo);
            cbx.llenarComboBox_Nivel_Puesto(comboBoxniveldepuesto);
            cbx.llenarComboBox_tipo_cliente(comboBoxtipocliente);

            radioButtoncliente.Checked = true;
            radioButtonadministrador.Checked = false;
            dateTimePicker2.Enabled = false;
            textBoxsalario.Enabled = false;
            comboBoxniveldepuesto.Enabled = false;
            comboBoxtipocliente.Enabled = false;

            if (radioButtoncliente.Checked)
            {
                comboBoxtipocliente.Enabled = true;
            }
            else if (radioButtonadministrador.Checked)
            {
                dateTimePicker2.Enabled = true;
                textBoxsalario.Enabled = true;
                comboBoxniveldepuesto.Enabled = true;
            }
                
        }

        private void radioButtonadministrador_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonadministrador.Checked)
            {
                dateTimePicker2.Enabled = true;
                textBoxsalario.Enabled = true;
                comboBoxniveldepuesto.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                textBoxsalario.Enabled = false;
                comboBoxniveldepuesto.Enabled = false;
            }
        

        }

        private void radioButtoncliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtoncliente.Checked)
            {
                comboBoxtipocliente.Enabled = true;
            }
            else
            {
                comboBoxtipocliente.Enabled = false;
            }
        }

        private void buttonbuscarcliente_Click(object sender, EventArgs e)
        {
            BuscarPersona frm1 = new BuscarPersona();
            frm1.ShowDialog();

            if(frm1.Clienteseleccionado != null)
            {
                Cliente_actual = frm1.Clienteseleccionado;
                textBoxprimernombre.Text = frm1.Clienteseleccionado.Nombre1;
                textBoxsegundonombre.Text = frm1.Clienteseleccionado.Nombre2;
                textBoxprimerapellido.Text = frm1.Clienteseleccionado.Apellido1;
                textBoxsegundoapellido.Text = frm1.Clienteseleccionado.Apellido2;
                dateTimePicker1.Text = frm1.Clienteseleccionado.Fecha_Nac;
                cbx.llenarComboBox_genero(comboBoxgenero);

            }
        }

        private void buttonactualizardatos_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();

            pCliente.Nombre1 = textBoxprimernombre.Text.Trim();
            pCliente.Nombre2 = textBoxsegundonombre.Text.Trim();
            pCliente.Apellido1 = textBoxprimerapellido.Text.Trim();
            pCliente.Apellido2 = textBoxsegundoapellido.Text.Trim();
            pCliente.Fecha_Nac = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
            pCliente.id_genero = Convert.ToInt32(comboBoxgenero.SelectedValue);
            pCliente.Cedula = Cliente_actual.Cedula;

            if (Clientes_Contr.Actualizar(pCliente) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
