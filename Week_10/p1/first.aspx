<%@ Page Language="C#" AutoEventWireup="true" CodeFile="first.aspx.cs" Inherits="first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1" AllowSorting="True" OnRowDataBound =" GridView1_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText ="Details" SortExpression ="Name">
                    <ItemTemplate>
                        <b>
                            Name:
                        </b>
                        <%#Eval("Name") %><br />
                        <b> Age:
                        </b>
                        <%#Eval("Age") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:companyConnectionString %>" SelectCommand="SELECT * FROM [Staff] ORDER BY [Name]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
