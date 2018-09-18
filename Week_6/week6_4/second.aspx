<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="second.aspx.cs" Inherits="second" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="mobileinfo" runat="server"></asp:Label>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
<br />
<br />
</asp:Content>

