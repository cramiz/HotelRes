<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationManagerStarterFile.aspx.cs" Inherits="ReservationManagerStarterFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="background-color: #FFE0C0; height: 100px; width: 601px; padding: 10px">
            <br />
            <asp:Label ID="Label1" runat="server" Width="99px" Height="19px">Select Person:</asp:Label>
            <asp:DropDownList ID="ddlPerson" runat="server" Width="187px" Height="21px" AutoPostBack="true" OnSelectedIndexChanged="ddlPerson_SelectedIndexChanged"></asp:DropDownList>&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Width="99px" Height="19px">Or:</asp:Label>
            <asp:Button ID="btnNew" runat="server" Width="91px" Height="24px" Text="Create New" OnClick="btnNew_Click" />&nbsp;
            <asp:Button ID="btnInsert" runat="server" Width="85px" Height="24px" Text="Insert New" OnClick="btnInsert_Click" />
        </div>
        <br />
        <div style="background-color: #E0E0E0; height: 392px; width: 601px; padding: 10px">
            <asp:Label ID="lblID" runat="server" Width="100px">ID: </asp:Label>
            <asp:TextBox ID="txtID" runat="server" Width="184px" Text="Do Not Type Values Here"></asp:TextBox>&nbsp;
            (ID will be filed in automatically.)
            <br />
            <asp:Label ID="lblName" runat="server" width ="100px">Name:</asp:Label>
            <asp:TextBox ID="txtName" runat="server" Width="184px"></asp:TextBox>
            <br />
                        <asp:Label ID="lblResults" runat="server" Width="575px" Height="121px" Font-Bold="true"></asp:Label>

        </div>
    </div>
    </form>
</body>
</html>
