<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Persons.aspx.cs" Inherits="WebApplication5.App_Forms.Persons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Persons</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id"
                OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                 OnRowDeleting="GridView1_RowDeleting"
               >
<%--                <a href="https://localhost:44377/App_Forms/">https://localhost:44377/App_Forms/</a>--%>
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:BoundField DataField="NationalityId" HeaderText="NationalityID" SortExpression="NationalityId" />
                    <asp:BoundField DataField="Birthdate" HeaderText="BirthDate" SortExpression="Birthdate" />
                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="BtnAdd" runat="server" Text="Add New Person"  OnClick="BtnAdd_Click"/>
        </div>
    </form>
</body>
</html>
