<%@ Page Language="C#" AutoEventWireup="true" CodeFile="first.aspx.cs" Inherits="first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:TemplateField HeaderText="Name" SortExpression="FirstName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FirstName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Book Title" HeaderText="Book Title" SortExpression="Book Title" ReadOnly =" True" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" ReadOnly =" True"/>
                <asp:BoundField DataField="CopiesSold" HeaderText="CopiesSold" SortExpression="CopiesSold"/>
                <asp:CommandField ShowEditButton =" True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:AuthorsConnectionString %>" 
            SelectCommand="SELECT * FROM [auth]" 
            UpdateCommand ="UPDATE [auth] set FirstName=@FirstName, CopiesSold=@CopiesSold WHERE Id=@Id"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
