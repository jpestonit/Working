
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default2 : System.Web.UI.Page
{
    /* any code you want to run when page is first served */
    /* adding runat to any element html server control allows access to properties*/
    protected void Page_Load(object sender, EventArgs e) 
    {
        if (IsPostBack)
        {
            
            lblStatus.Text = "Not Pushed";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "pushed";
        string name = TextBox1.Text;
        Class2 myClass = new Class2();
        
        tblResults.DataSource = myClass.selectCustomer(name);
        tblResults.DataBind();
        
        Feedback.Text = "Load Successful.";
        }
    }
