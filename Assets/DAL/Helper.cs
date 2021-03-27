using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public static class Helper
{
    static SqlConnection connection;
    public static void Connect()
    {
        connection = new SqlConnection(@"Data Source=DESKTOP-FULFKLH\SQLEXPRESS;Initial Catalog=DBPinkRunner;Integrated Security=True");

    }

    public static void ConnectionOpenClose()
    {
        if(connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
        else
        {
            connection.Close();
        }
    }
}
