<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>

<script runat="server">
    public String heading = "Page Heading";
</script>
<asp:Panel ID ="menuPanel" runat="server">
<a href="Default.aspx" target="_self">default</a><br />
<a href="Default2.aspx" target="_self">default2</a><br />
<a href="Default3.aspx" target ="_self">default3</a><br />
<a href="Default4.aspx" target ="_self">default4</a><br />
    </asp:Panel>
<h1> <%= heading %></h1>
