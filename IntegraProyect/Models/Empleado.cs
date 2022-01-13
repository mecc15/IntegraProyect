using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleado
/// </summary>
public class Empleado
{
    //Propiedades de Clase Empleado
    public int idEmpleado { get; set; }
    public string apellidoEmpleado { get; set; }
    public string nombreEmpleado { get; set; }
    public string telefonoEmpleado { get; set; }
    public string correoEmpleado { get; set; }
    public string fotoEmpleado { get; set; }
    public string fechaContratoEmpleado { get; set; }

    public Empleado() { }

    //Constructor Empleado
    public Empleado(int idEmpleado,string apellidoEmpleado,string nombreEmpleado,
        string telefonoEmpleado,string correoEmpleado,string fotoEmpleado,string fechaContratoEmpleado)
    {
        this.idEmpleado = idEmpleado;
        this.apellidoEmpleado = apellidoEmpleado;
        this.nombreEmpleado = nombreEmpleado;
        this.telefonoEmpleado = telefonoEmpleado;
        this.correoEmpleado = correoEmpleado;
        this.fotoEmpleado = fotoEmpleado;
        this.fechaContratoEmpleado = fechaContratoEmpleado;
    }
}