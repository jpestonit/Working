<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
    
    </div>
  
    <p>
        
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
         <telerik:RadGrid ID="tblResults" runat="server"> </telerik:RadGrid>
         <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label> 
            </ContentTemplate>

    </asp:UpdatePanel>
   
    
    <uc1:WebUserControl ID="WebUserControl1" runat="server" />
   
    
    </form>
</body>
</html>
