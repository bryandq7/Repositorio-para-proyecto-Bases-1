using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionario_def1
{
    public class Factura
    {

        public String Nombre_cuestionario { get; set; }
        public int activo { get; set; }
        public int cantidad_preguntas { get; set; }
        public string Fecha_creacion { get; set; }
        public int idCuestionario { get; set; }
        public string Usuario { get; set; }
        public string Nombre_creador { get; set; }
        public string Apellid1_creador { get; set; }
        public string Apellido2_creador { get; set; }
        public int cedula { get; set; }
        public int monto_total { get; set; }
        public int sub_total { get; set; }
        public int precio { get; set; }
        public int idFactura { get; set; }
        public int idlinea { get; set; }
        public string detalle_linea { get; set; }


        public Factura() { }

        public Factura(string pNombre_cuestionario, int pactivo, int pcantidad_preguntas, string pFecha_creacion,
        int pidCuestionario,  string pUsuario, string pNombre_creador, string pApellido1, string pApellido2, int pcedula, 
        int pmonto_total,int psub_total, int pprecio, int pidfactura, int pidlinea, string pdetalle_linea)

        {
            this.Nombre_cuestionario = pNombre_cuestionario;
            this.activo = pactivo;
            this.cantidad_preguntas = pcantidad_preguntas;
            this.Fecha_creacion = pFecha_creacion;
            this.idCuestionario = pidCuestionario;
            this.Usuario = pUsuario;
            this.Nombre_creador = pNombre_creador;
            this.Apellid1_creador = pApellido1;
            this.Apellido2_creador = pApellido2;
            this.cedula = pcedula;
            this.monto_total = pmonto_total;
            this.sub_total = psub_total;
            this.precio = pprecio;
            this.idFactura = pidfactura;
            this.idlinea = pidlinea;
            this.detalle_linea = pdetalle_linea;
        }
    }
}
