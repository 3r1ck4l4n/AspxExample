using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspxExample
{
    public class Alumno
    {
        private String boleta;
        private String nombre;
        private int calificacion;

        public Alumno(String boleta, String nombre, int calificacion)
        {
            this.Boleta = boleta;
            this.Nombre = nombre;
            this.Calificacion = calificacion;
        }
        public Alumno(String boleta, String nombre)
        {
            this.Boleta = boleta;
            this.Nombre = nombre;
           
        }

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Boleta { get => boleta; set => boleta = value; }
    }
}       