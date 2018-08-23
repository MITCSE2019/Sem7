<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" accept="image/*" />
    
    &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Select background color"></asp:Label>
        <asp:DropDownList ID="backcolordropdown" runat="server" Height="16px" style="margin-left: 21px" Width="121px">
        </asp:DropDownList>
&nbsp;<br />
        <br />
        <asp:Label ID="message" runat="server" Text="message"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="msg" runat="server" style="margin-left: 0px" Width="171px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Select Font Size"></asp:Label>
        <asp:DropDownList ID="fontdropdown" runat="server" Height="18px" style="margin-left: 14px" Width="96px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="color" runat="server" Text="Select Color"></asp:Label>
        <asp:DropDownList ID="colordropdown" runat="server" Height="16px" OnSelectedIndexChanged="colordropdown_SelectedIndexChanged" style="margin-left: 25px" Width="124px">
        </asp:DropDownList>
    
    </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="generateCover" Text="Generate!" />
        </p>
        <asp:Panel ID="cover" runat="server" Height="178px" Width="565px">
            &nbsp;<asp:TextBox ID="displaymessage" runat="server" Width="548px"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>
