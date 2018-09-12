<%@ Page Language="C#" AutoEventWireup="true" CodeFile="election.aspx.cs" Inherits="election" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Candidate&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="52px">
          
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>
&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
             
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Please select a house!"></asp:RequiredFieldValidator>
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Contact Number&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rvf" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="Please enter a number" style="position: relative"></asp:RequiredFieldValidator>
    
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid Number" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Validate" OnClick="Button1_Click" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
