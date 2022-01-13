using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;//proveedor de conexion a SQL-SERVER nativo

/// <summary>
/// Conexion con SQL-SERVER , Base de Datos Integra
/// </summary>
public class Conexion
{
    //Objeto de conexion conex a partir de una instancia sqlConnection
   public SqlConnection conex = new SqlConnection("Data source =localhost; Initial catalog = integra; Integrated Security=True");
   
    // metodo para abrir conexion validando si no esta abierta
   public void abrir_conexion()
    {
        if (conex.State == ConnectionState.Closed)
            conex.Open();
    }

    //metodo para cerrar conexion validando si no esta cerrada

    public void cerrar_conexion()
    {
        if (conex.State == ConnectionState.Open)
            conex.Close();
    }
        
   
}