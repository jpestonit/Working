using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public Class1()
    { }
         public DataTable allCustomers()
    {

        DataTable myDT = new DataTable();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.Text;
        mySqlCommand.CommandText = "SELECT [CustomerID],[CompanyName],[ContactName],[ContactTitle] FROM [Northwind].[dbo].[Customers] WHERE CUSTOMERID = A%";

       /* mySqlCommand.Parameters.AddWithValue("@Process", 11);
        mySqlCommand.Parameters.AddWithValue("@UserName", UserName);
        mySqlCommand.Parameters.AddWithValue("@Status", Status); */
        

        try
        {
            SQLConn.Open();

            myDT.Load(mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection));

            SQLConn.Close();
            return myDT;
        }

        catch
        {
            return null;
        }


    }


    //get ticket by location
   
    

    }
