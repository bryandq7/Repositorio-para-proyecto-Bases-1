using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionario_def1
{
    public class Cuestionario
    {

        public String Nombre_cuestionario { get; set; }
        public int activo { get; set; }
        public int cantidad_preguntas { get; set; }
        public string Fecha_creacion { get; set; }
        public string Pregunta { get; set; }
        public int Puntos { get; set; }
        public int idtipo_pregunta { get; set; }
        public string tipo_pregunta { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public string Estado1 { get; set; }
        public string Estado2 { get; set; }
        public string Estado3 { get; set; }
        public string Estado4 { get; set; }




        public Cuestionario() { }

        public Cuestionario(string pNombre_cuestionario, int pactivo, int pcantidad_preguntas, string pFecha_creacion,
           string pPregunta, int pPuntos, int pidtipo_pregunta, string ptipo_pregunta, string pRespuesta1,
           string pRespuesta2, string pRespuesta3, string pRespuesta4, string pEstado1, string pEstado2
            , string pEstado3, string pEstado4 )

        {
            this.Nombre_cuestionario = pNombre_cuestionario;
            this.activo = pactivo;
            this.cantidad_preguntas = pcantidad_preguntas;
            this.Fecha_creacion = pFecha_creacion;
            this.Pregunta = pPregunta;
            this.Puntos = pPuntos;
            this.idtipo_pregunta = pidtipo_pregunta;
            this.tipo_pregunta = ptipo_pregunta;
            this.Respuesta1 = pRespuesta1;
            this.Respuesta2 = pRespuesta2;
            this.Respuesta3 = pRespuesta3;
            this.Respuesta4 = pRespuesta4;
            this.Estado1 = pEstado1;
            this.Estado2 = pEstado2;
            this.Estado3 = pEstado3;
            this.Estado4 = pEstado4;
        }

    }
    }
