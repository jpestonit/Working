using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Class2 myClass = new Class2();
            DropDownList1.DataSource = myClass.employeeList();
            DropDownList1.DataTextField = "LastName";
            DropDownList1.DataValueField = "LastName";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string name = DropDownList1.SelectedValue.ToString();
        Class2 myClass = new Class2();
        tblResults.DataSource = myClass.getEmployeeHistory(name);
        tblResults.DataBind();
        
    }
}