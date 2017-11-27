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
        public string cUsuario;
       
        
        public ingreso_persona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (textBoxprimernombre.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxsegundonombre.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxprimerapellido.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxsegundoapellido.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxcedula.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxnumerotelefono.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxcorreoelectronico.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxusuario.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (textBoxcontrasena.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (comboBoxgenero.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (comboBoxtipocliente.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (comboBoxtipocorreo.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }
            if (comboBoxtipotelefono.Text == "")
            {
                MessageBox.Show("Revise que todos los campos estén llenos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = contador + 1;
            }


            try
            {
                if (contador == 0)
                {
                    bool cedula = true;
                    bool usuario = true;
                    bool correo = true;
                    bool telefono = true;


                    //try
                    //{
                    cedula = Clientes_Contr.Revisar_cedula(Convert.ToInt32(textBoxcedula.Text.Trim()));
                    usuario = Clientes_Contr.Revisar_usuario(textBoxusuario.Text.Trim().ToString());
                    telefono = Clientes_Contr.Revisar_telefono(Convert.ToInt32(textBoxnumerotelefono.Text.Trim()));
                    correo = Clientes_Contr.Revisar_correo(textBoxcorreoelectronico.Text.Trim().ToString());
                    //}
                    //catch (Exception Ex)
                    //{
                    //    cedula = 0;
                    //    throw;
                    //}







                    if (cedula == true)
                    {
                        MessageBox.Show("Esta cédula ya está registrada");

                    }

                    if (usuario == true)
                    {
                        MessageBox.Show("Esta usuario ya está registrado");

                    }



                    if (telefono == true)
                    {
                        MessageBox.Show("Este telefono ya está registrado");

                    }

                    if (correo == true)
                    {
                        MessageBox.Show("Este correo ya está registrado");

                    }
                    if (contador == 0 && cedula == false && usuario == false
                        && telefono == false && correo == false)
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

                        if (radioButtoncliente.Checked)
                        {
                            pCliente.id_tipo_usuario = Convert.ToInt32(1);
                        }
                        if (radioButtonadministrador.Checked)
                        {
                            pCliente.id_tipo_usuario = Convert.ToInt32(2);
                        }
                        pCliente.id_tipo_cliente = Convert.ToInt32(comboBoxtipocliente.SelectedValue);

                        pCliente.activo = Convert.ToInt32(1);

                        int resultado = Clientes_Contr.Agregar(pCliente);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
                throw;
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

            cbx.llenarComboBox_tipo_cliente(comboBoxtipocliente);


        }

        private void ingreso_persona_Load(object sender, EventArgs e)
        {
            cbx.llenarComboBox_genero(comboBoxgenero);
            cbx.llenarComboBox_tipo_Telefono(comboBoxtipotelefono);
            cbx.llenarComboBox_tipo_correo(comboBoxtipocorreo);

            cbx.llenarComboBox_tipo_cliente(comboBoxtipocliente);

            radioButtoncliente.Checked = true;
            radioButtonadministrador.Checked = false;


            comboBoxtipocliente.Enabled = false;

            if (radioButtoncliente.Checked)
            {
                comboBoxtipocliente.Enabled = true;
            }
            else if (radioButtonadministrador.Checked)
            {

            }

            if(cUsuario == "")
            {
                buttonbuscarcliente.Enabled = false;
                buttonactualizardatos.Enabled = false;
            }
            else
            {
                button1.Enabled = false;

            }

            
                
        }

        private void radioButtonadministrador_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonadministrador.Checked)
            {

            }
            else
            {

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
            BuscarPersona frm4 = new BuscarPersona();
            frm4.ShowDialog();

            if (frm4.Clienteseleccionado != null)
            {
                MessageBox.Show(frm4.Clienteseleccionado.Nombre1, "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cliente_actual = frm4.Clienteseleccionado;
                textBoxprimernombre.Text = frm4.Clienteseleccionado.Nombre1;
                textBoxsegundonombre.Text = frm4.Clienteseleccionado.Nombre2;
                textBoxprimerapellido.Text = frm4.Clienteseleccionado.Apellido1;
                textBoxsegundoapellido.Text = frm4.Clienteseleccionado.Apellido2;
                dateTimePicker1.Text = frm4.Clienteseleccionado.Fecha_Nac;
                cbx.llenarComboBox_genero(comboBoxgenero);
                //this.Close();
                textBoxcedula.Enabled = false;
                comboBoxtipocliente.Enabled = false;
                comboBoxtipotelefono.Enabled = false;
                textBoxnumerotelefono.Enabled = false;
                textBoxcorreoelectronico.Enabled = false;
                comboBoxtipocorreo.Enabled = false;
                textBoxusuario.Enabled = false;
                textBoxcontrasena.Enabled = false;
                radioButtonadministrador.Enabled = false;
                radioButtoncliente.Enabled = false;
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

            this.Close();
        }

        private void textBoxprimernombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBoxsegundonombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBoxprimerapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBoxsegundoapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBoxcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBoxnumerotelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        


    }
}
