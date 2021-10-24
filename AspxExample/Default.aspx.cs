using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspxExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            
            Globals.alumnos.Add(new Alumno("2019600", "Erick"));
            Globals.alumnos.Add(new Alumno("2019700", "Juan"));
            Globals.alumnos.Add(new Alumno("2019800", "Eva"));
            Globals.alumnos.Add(new Alumno("2019900", "Sandra"));
            Globals.alumnos.Add(new Alumno("2020600", "Brandon"));
            Globals.alumnos.Add(new Alumno("2020700", "Thompson"));
            Globals.alumnos.Add(new Alumno("2020800", "Fernando"));
            Globals.alumnos.Add(new Alumno("2020900", "Luis"));
            Globals.alumnos.Add(new Alumno("2020160", "Montserrat"));
            Globals.alumnos.Add(new Alumno("2020300", "Abraham"));
            Int32[] calificaciones = new Int32[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            String[] labels1 = new String[10]{"boleta1", "boleta2", "boleta3" , "boleta4", "boleta5", "boleta6", "boleta7", "boleta8", "boleta9", "boleta10" };
            String[] labels2 = new String[10] { "nombre1", "nombre2", "nombre3", "nombre4", "nombre5", "nombre6", "nombre7", "nombre8", "nombre9", "nombre10" };


            if (!this.IsPostBack)
            {
                for (int i = 0; calificaciones.Length > i; i++)
                {
                    DropDownList1.Items.Add(calificaciones[i].ToString());
                    DropDownList2.Items.Add(calificaciones[i].ToString());
                    DropDownList3.Items.Add(calificaciones[i].ToString());
                    DropDownList4.Items.Add(calificaciones[i].ToString());
                    DropDownList5.Items.Add(calificaciones[i].ToString());
                    DropDownList6.Items.Add(calificaciones[i].ToString());
                    DropDownList7.Items.Add(calificaciones[i].ToString());
                    DropDownList8.Items.Add(calificaciones[i].ToString());
                    DropDownList9.Items.Add(calificaciones[i].ToString());
                    DropDownList10.Items.Add(calificaciones[i].ToString());
                    Label lbl1 = (Label)FindControl(labels1[i]);
                    lbl1.Text = Globals.alumnos[i].Boleta;
                    Label lbl2 = (Label)FindControl(labels2[i]);
                    lbl2.Text = Globals.alumnos[i].Nombre;
               
                }
            }
            

            
        }

        public void Button1_Click(object sender, EventArgs e)
        { 
            String[] drop = { "DropDownList1", "DropDownList2", "DropDownList3", "DropDownList4", "DropDownList5", "DropDownList6", "DropDownList7", "DropDownList8", "DropDownList9", "DropDownList10" };
            
             for(int i=0; i<10; i++)
            {   
                DropDownList drp = (DropDownList)FindControl(drop[i]);
                Globals.alumnos[i].Calificacion = Int16.Parse(drp.SelectedValue);
                
                
            }
            
            
            Estadisticas est = new Estadisticas();
            califMax.Text = est.CalificionMaxima(Globals.alumnos).ToString();
            califMin.Text = est.CalificionMinima(Globals.alumnos).ToString();
            promedio.Text = est.Promedio(Globals.alumnos).ToString();
            aprobado.Text = est.NumAprobados(Globals.alumnos).ToString();
            reprobado.Text = est.NumReprobados(Globals.alumnos).ToString(); ;
        }


    }
}