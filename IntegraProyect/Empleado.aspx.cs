using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace IntegraProyect
{
    public partial class Empleado : System.Web.UI.Page
    {
        ControlEmpleado cemp = new ControlEmpleado();//instancia ControlEmpleado
        protected void Page_Load(object sender, EventArgs e)
        {
            //llenado de tabla con registros al cargar pagina
            llenarTabla(cemp.devolverEmpleados());
        }
        //metodo para llenado de tabla
        string llenarTabla(DataTable dt)
        {
            string res = "";
            res = "<table><tr><th>ID</th><th>Apellido</th><th>Nombre</th><th>Telefono</th><th>Correo</th><th>Foto</th><th>Fecha Contrato</th><th>Opcion</th></tr>";
            foreach (DataRow r in dt.Rows)
            {
                res += "<tr><td>" + r[0] + "</td><td>" + r[1] + "</td><td>" + r[2] + "</td><td>" + r[3] + "</td><td>" + r[4] + "</td><td><img width='60' height='60' src='img/" + r[5] + "'></td><td>" + r[6] + "</td><td><input type='button' onclick=$('#TextBox1').val('" + r[0] + "');$('#TextBox2').val('" + r[1] + "');$('#TextBox3').val('" + r[2] + "');$('#TextBox4').val('" + r[3] + "');$('#TextBox5').val('" + r[4] + "');$('#Image1').attr('src','img/" + r[5] + "');$('#TextBox6').val('" + r[6] + "') value=Editar></td></tr>";
            }

            res += "</table>";

            Label1.Text = res;
            return res;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "";
            //validacion y subida de imagen
            if (FileUpload1.HasFile)
            {
                nombreArchivo = FileUpload1.FileName;
                string ruta = "~/img/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

            }
            cemp.agregarEmpleado(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, nombreArchivo, TextBox6.Text);
            //refrescamos tabla 
            llenarTabla(cemp.devolverEmpleados());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "";
            //validacion y subida de imagen
            if (FileUpload1.HasFile)
            {
                nombreArchivo = FileUpload1.FileName;
                string ruta = "~/img/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

            }
            cemp.modificarEmpleado(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, nombreArchivo, TextBox6.Text);
            //refrescamos tabla 
            llenarTabla(cemp.devolverEmpleados());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cemp.eliminarEmpleado(TextBox1.Text);
            //refrescamos tabla 
            llenarTabla(cemp.devolverEmpleados());
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter write = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
            document.Open();
            document.Add(new Phrase("FICHA EMPLEADO"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("ID : " + TextBox1.Text));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("APELLIDO : " + TextBox2.Text));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("NOMBRE : " + TextBox3.Text));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("TELEFONO : " + TextBox4.Text));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("CORREO : " + TextBox5.Text));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("\n"));
            document.Add(new Phrase("FECHA CONTRATO : " + TextBox6.Text));
            document.Close();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=fichaEmpleado" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            llenarTabla(cemp.buscarEmpleado(TextBox7.Text));
        }
    }
}