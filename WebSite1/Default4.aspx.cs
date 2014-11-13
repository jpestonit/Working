
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {   
        int prodID = int.Parse(TextBox1.Text);
        Class2 myClass = new Class2();
        tblResults.DataSource = myClass.mostSoldOfItem(prodID);
        tblResults.DataBind();
    }
}