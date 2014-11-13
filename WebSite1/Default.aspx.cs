using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblStatus.Text="not pushed";
        }

        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "pushed button";
        Class1 myclass = new Class1();
        tblResults.DataSource = myclass.allCustomers();
        tblResults.DataBind();

    }
}