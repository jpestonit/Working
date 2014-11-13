using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox3.Text = DateTime.Now.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int invoiceVal = int.Parse(TextBox1.Text);
        string custName = TextBox2.Text;
        DateTime current = DateTime.Parse(TextBox3.Text);
        string dealerCode = TextBox4.Text;
        int productSku = int.Parse(TextBox5.Text);
        float sellPrice = float.Parse(TextBox6.Text);
        int assocNum = int.Parse(TextBox7.Text);
        string loc = DropDownList1.SelectedValue.ToString(); // not sure if this will work by itself.
        EMail();
    }

    
   public void EMail()
    {
        String myMessage = "";
        myMessage = "InvoiceVal:" + TextBox1.Text + "\n Customer Name:" + TextBox2.Text + "\nDate:" + TextBox3.Text + "\nDealerCode:" + TextBox4.Text + "\nProduct Sku:"+ TextBox5 
            + "\nSell Price:" + TextBox6 + "\n AssocNum:" + TextBox7 + "\nLocation"+DropDownList1.SelectedValue.ToString();
        

     

        try
        {
            ////MailHelper.SendMailMessage("no-reply@execcell.com", "matt@execcell.com", "", "", "Bank Deposit - " + StoreLst.SelectedValue + " " + CurrentTotal.ToString(), MyMessage);
            MailHelper.SendMailMessage("no-reply@execcell.com", "joseph.pestonit@executivecellularphones.com", "", "", ""+ DropDownList1.SelectedValue + " | " + String.Format("{0:C}"), myMessage);
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message.ToString();
        }
        finally
        {
            lblStatus.Text = "Mail Sent";
        };
    }  

}