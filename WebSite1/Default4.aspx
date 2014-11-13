<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="_Default4" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmployeeSoldMost</title>
</head>
<body>
    
    <form id="form1" runat="server">
     <uc1:WebUserControl ID="WebUserControl2" runat="server" heading="Enter Product ID" />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
       
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        <asp:Literal ID="Feedback" runat="server"></asp:Literal>
             <telerik:RadGrid ID="tblResults" runat="server"> </telerik:RadGrid>
         <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
             </ContentTemplate>

    </asp:UpdatePanel>
    </div>
       
       
    </form>
</body>
</html>
