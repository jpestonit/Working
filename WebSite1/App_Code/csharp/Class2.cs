using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public class Class2
{
    public Class2()
    {
     
    }
    public DataTable selectCustomer(String customerID)

    {
        String custID = customerID;
        DataTable myDT = new DataTable();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        mySqlCommand.CommandText = "getCustomer";
        mySqlCommand.Parameters.AddWithValue("@CustomerID", custID);
             
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

    public DataTable selectedItemRev(int productID)
    {
        int prodID = productID;

        DataTable myDT = new DataTable();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        mySqlCommand.CommandText = "getSelectedItemRev";
        mySqlCommand.Parameters.AddWithValue("@ProductID", prodID);

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

    public DataTable mostSoldOfItem(int productID)
    {
        int prodID = productID;

        DataTable myDT = new DataTable();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        mySqlCommand.CommandText = "getEmployeeSoldMostOf";
        mySqlCommand.Parameters.AddWithValue("@ProductID", prodID);

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
    
    public DataSet employeeList(){
       
        DataSet myList = new DataSet();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        mySqlCommand.CommandText = "EmployeesLastName";

        try
        {
            SQLConn.Open();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(myList);
            return myList;
        }
        catch
        {
            return null;
        }
        

    }
    public DataTable getEmployeeHistory(string name)
    {
        string n = name;
        DataTable myDT = new DataTable();
        SqlConnection SQLConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcs"].ToString());
        SqlCommand mySqlCommand = SQLConn.CreateCommand();

        mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        mySqlCommand.CommandText = "getEmployeeHistory";
        mySqlCommand.Parameters.AddWithValue("@LastName",n );

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
}