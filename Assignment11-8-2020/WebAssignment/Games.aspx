<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="WebAssignment.Games" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="A" OnCheckedChanged="RadioButton1_CheckedChanged1" Text="Cricket Players" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="A" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Players" />
        <asp:Panel ID="Panel1" runat="server">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HtmlSachinTendulkar.html">SachinTendulkar</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HtmlGowtham Gambir.html">Gowtham Gambir</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/HtmlM.S.Dhoni.html">M.S.Dhoni</asp:HyperLink>
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/HtmlSerenaWilliams.html">SerenaWilliams</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/HtmlAndyMurray.html">Andy Murray</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/HtmlRodLaver.html">Rod Laver</asp:HyperLink>
        </asp:Panel>
    </form>
    
</body>
</html>
