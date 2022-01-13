using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Metodos para realizar CRUD y busquedas en tambla empleado
/// </summary>
public class MantenimientoEmpleado
{
    public MantenimientoEmpleado()
    { }
        String sql;//variable para sentencias SQL
        Conexion con = new Conexion();//Objeto de Conexion
        SqlCommand cmd;//variable para preparar query a BD
        SqlDataReader read;
        String error;//variable para manejo de errores
        int res = 0;//variable para resultados de insert y update
         
    //metodo para devolver todos los registros o buscar por nombre o apellido
        public DataTable mostrarEmpleados(String tabla,String buscar)
    {
        DataTable datos = new DataTable();//DataTable con registros
        SqlDataAdapter adap;
        if (buscar == "")
            this.sql = "select * from " + tabla;
        else
            this.sql = "select * from " + tabla + " where nombreEmpleado like '%" + buscar + "%' or apellidoEmpleado like '%" + buscar + "%'";
        try
        {
            con.abrir_conexion();
            adap = new SqlDataAdapter(this.sql, con.conex);
            adap.Fill(datos);
         
        }
        catch(Exception ex)
        {
            error = "Error " + ex.ToString();
        }
        finally
        {
            con.cerrar_conexion();
        }
        return datos;
    }

    //Metodo para insertar registros nuevos de empleados
    public string agregarEmpleado(Empleado emp)
    {
        cmd = new SqlCommand(String.Format("insert into empleado(apellidoEmpleado,nombreEmpleado,telefonoEmpleado,correoEmpleado,fotoEmpleado,fechaContratoEmpleado) values('{0}','{1}','{2}','{3}','{4}','{5}')",
            emp.apellidoEmpleado, emp.nombreEmpleado, emp.telefonoEmpleado, emp.correoEmpleado, emp.fotoEmpleado, emp.fechaContratoEmpleado),con.conex);
        try
        {
            con.abrir_conexion();
            res = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            error = "Error" + ex.ToString();
        }
        finally
        {
            con.cerrar_conexion();
        }
        return "";
    } 

    //Metodo para actualizar registros de empleados
    public string modificarEmpleado(Empleado emp)
    {
        if(emp.fotoEmpleado=="")//validacion si cambio img
            cmd = new SqlCommand(String.Format("update empleado set apellidoEmpleado='{0}',nombreEmpleado='{1}',telefonoEmpleado='{2}',correoEmpleado='{3}',fechaContratoEmpleado='{4}' where idEmpleado='{5}'",
             emp.apellidoEmpleado, emp.nombreEmpleado, emp.telefonoEmpleado, emp.correoEmpleado, emp.fechaContratoEmpleado, emp.idEmpleado), con.conex);
        else
            cmd = new SqlCommand(String.Format("update empleado set apellidoEmpleado='{0}',nombreEmpleado='{1}',telefonoEmpleado='{2}',correoEmpleado='{3}',fotoEmpleado='{4}',fechaContratoEmpleado='{5}' where idEmpleado='{6}'",
            emp.apellidoEmpleado, emp.nombreEmpleado, emp.telefonoEmpleado, emp.correoEmpleado, emp.fotoEmpleado, emp.fechaContratoEmpleado, emp.idEmpleado), con.conex);

        try
        {
            con.abrir_conexion();
            res = cmd.ExecuteNonQuery();
        }catch(Exception ex)
        {
            error = "Error " + ex.ToString();
        }
        finally
        {
            con.cerrar_conexion();
        }
        return "";
    }

    //Metodo para elimnar registros de empleados
    public string eliminarEmpleado(Empleado emp)
    {
        cmd = new SqlCommand(String.Format("delete from empleado where idEmpleado='{0}'", emp.idEmpleado), con.conex);
        try
        {
            con.abrir_conexion();
            res=cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            error = "Error " + ex.ToString();
        }

        return "";
    }
        


    
}