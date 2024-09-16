<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="WebApplication5.App_Forms.AddPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="LabL" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
                <br />
             <asp:Label ID="LblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label2" runat="server" Text="Age:"></asp:Label>
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label3" runat="server" Text="NationalityID:"></asp:Label>
            <asp:TextBox ID="TxtNat" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label4" runat="server" Text="BirthDate:"></asp:Label>
            <asp:TextBox ID="TxtBD" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click"/>
        </div>
    </form>
</body>
</html>
