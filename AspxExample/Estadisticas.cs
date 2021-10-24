using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspxExample
{
    public class Estadisticas
    {
        List<Alumno> alumnos;
       
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        public int NumAprobados(List<Alumno> alumnos) {
            int numAprobados=0;
            foreach (Alumno alumno in alumnos) {
                if (alumno.Calificacion > 5)
                {
                    numAprobados++;
                }   
            }
            return numAprobados;
        }

        public int NumReprobados(List<Alumno> alumnos)
        {
            int numReprobados = 0;
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Calificacion < 5&&alumno.Calificacion!=0)
                {
                    numReprobados++;
                }
            }
            return numReprobados;
        }
        public float Promedio(List<Alumno> alumnos)
        {
            float promedio;
            int sumatoria = 0;
            foreach (Alumno alumno in alumnos)
            { 
                
                sumatoria += alumno.Calificacion;
            }
            promedio = sumatoria / 10;
            return promedio;
        }

        public int CalificionMinima(List<Alumno> alumnos)
        {
            int calificionMinima = 10;
            foreach(Alumno alumno in alumnos){
                calificionMinima = calificionMinima > alumno.Calificacion&&alumno.Calificacion!=0 ? alumno.Calificacion : calificionMinima;
            }

            return calificionMinima;
            
        }

        public int CalificionMaxima(List<Alumno> alumnos)
        {
            int califMaxima = 0;
            foreach (Alumno alumno in alumnos)
            {
                califMaxima = califMaxima <= alumno.Calificacion ? alumno.Calificacion : califMaxima;
            }
            return califMaxima;
        }
    }
}