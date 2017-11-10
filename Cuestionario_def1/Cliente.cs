using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionario_def1
{
    public class Cliente
    {
        public int Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Fecha_Nac { get; set; }
        public string Genero { get; set; }
  

        public int Numero_telefono { get; set; }


        public string Correo_electronico { get; set; }


        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Descrip_tipousuario { get; set; }

        public int id_genero { get; set; }
        public int id_tipo_telefono { get; set; }
        public int id_tipo_correo { get; set; }
        public int id_tipo_cliente { get; set; }
        public int id_tipo_usuario { get; set; }
        public int activo { get; set; }



        public Cliente() { }

        public Cliente(int pCedula, string pNombre1, string pNombre2, string pApellido1,
            string pApellido2, string pFecha_Nac, string Genero, string pDireccionmasdetalles,
            int pNumero_telefono, string pCorreo_electronico,
            string pUsuario, string pContrasena,  int pid_genero,
            int pid_tipo_telefono, int pid_tipo_correo, int pid_tipo_cliente,
            int pid_tipo_usuario, int pactivo, string pDescrip_tipousuario)

        {
            this.Cedula = pCedula;
            this.Nombre1 = pNombre1;
            this.Nombre2 = pNombre2;
            this.Apellido1 = pApellido1;
            this.Apellido2 = pApellido2;
            this.Fecha_Nac = pFecha_Nac;
            this.id_genero = pid_genero;

            this.Numero_telefono = pNumero_telefono;
            this.id_tipo_telefono = pid_tipo_telefono;
            this.Correo_electronico = pCorreo_electronico;
            this.id_tipo_correo = pid_tipo_correo;
            this.Usuario = pUsuario;
            this.Contrasena = pContrasena;
            this.id_tipo_usuario = pid_tipo_usuario;
            this.id_tipo_cliente = pid_tipo_cliente;
            this.activo = pactivo;
            this.Descrip_tipousuario = pDescrip_tipousuario;



        }

    }
}
