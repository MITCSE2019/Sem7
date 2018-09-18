<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="first.aspx.cs" Inherits="first" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style3 {
        margin-left: 40px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:DropDownList ID="mobile_list" runat="server">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;
<br />
<br />
<asp:Button ID="Button1" runat="server" OnClick="clickevent" Text="Click" />
<br />
    
</asp:Content>

