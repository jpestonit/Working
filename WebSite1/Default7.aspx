<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="_Default7" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Some Web Form</title>
<h1> Web Form</h1>
    
</head>
<body>
    <form id="form1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

   

    <div>
    <asp:Label ID="Label1" runat="server" Text="Invoice/Order Number:"></asp:Label>
    <asp:TextBox ID="TextBox1"  runat="server" Width="460px" style="margin-left: 18px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">&lt;--Required</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Invalid" ValidationExpression="\d+" ValidationGroup="AllValidators">Invalid, Numbers Only!</asp:RegularExpressionValidator>
       
    </div>

    <div>
    <asp:Label ID="Label2" runat="server" Text="Customer Name/BAN:"></asp:Label>
    <asp:TextBox ID="TextBox2"  runat="server" Width="460px" style="margin-left: 18px"></asp:TextBox>
    </div>
        
    <div>
    <asp:Label ID="Label3" runat="server" Text="DATE:"></asp:Label>
    <asp:TextBox ID="TextBox3"  runat="server" Width="460px" style="margin-left: 18px" ></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label4" runat="server" Text="Dealer Code:"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" Width="460px" style="margin-left: 18px"></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label5" runat="server" Text="PRODUCT SKU:"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server" Width="460px" style="margin-left: 18px"></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label6" runat="server" Text="Selling Price:"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server" Width="460px" style="margin-left: 18px"></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label7" runat="server" Text="ASSOC#(ECP)"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" Width="460px" style="margin-left: 18px"></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label8" runat="server" Text="LOCATION:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" style="margin-left: 16px" Width="211px">
        </asp:DropDownList>
    </div>

    <div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="lblStatus" runat="server" Text="Not Sent"></asp:Label>
    </div>
       

    </form>
    
</body>
</html>
