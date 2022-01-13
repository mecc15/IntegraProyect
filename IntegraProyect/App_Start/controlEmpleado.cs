using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



/// <summary>
/// Clase encargada de realizar las transacciones entre la vista y el modelo
/// </summary>
public class ControlEmpleado
{
    MantenimientoEmpleado me = new MantenimientoEmpleado();//instaancia de la clase que contine el CRUD
    Empleado emp;
    public ControlEmpleado()
    {
       
    }
    //llamada de metodo que devuelve todos los empleados
    public DataTable devolverEmpleados()
    {
        return me.mostrarEmpleados("empleado","");
    }

    //llamada de metodo que busca empleados por apellido o nombre
    public DataTable buscarEmpleado(String empleado)
    {
        return me.mostrarEmpleados("empleado",empleado);
    }
    //llamada de Metodo para insertar nuevo registro de empleado
    public string agregarEmpleado(String apellido, String nombre, String telefono, String correo, String foto, String fecha)
    {
        emp = new Empleado(1, apellido, nombre, telefono, correo, foto, fecha);
        return me.agregarEmpleado(emp);
    }
    //llamada de metodo para modificar registro de empleado
    public string modificarEmpleado(String idEmpleado,String apellido, String nombre, String telefono, String correo, String foto, String fecha)
    {
        
        emp = new Empleado(Int32.Parse(idEmpleado), apellido, nombre, telefono, correo, foto, fecha);
        return me.modificarEmpleado(emp);
    }
    //llamada de metodo para eliminar registro de empleado
    public String eliminarEmpleado(String idEmpleado)
    {
        return me.eliminarEmpleado(new Empleado(Int32.Parse(idEmpleado),"","","","","",""));
    }

}