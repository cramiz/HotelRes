<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationFormResult.aspx.cs" Inherits="ReservationFormResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="App_Themes/Monochrome/Monochrome.css" type="text/css" rel="stylesheet" />
    <script src="../Scripts/modernizr-2.7.1.js"></script>

    <meta charset="utf-8" />
    <title>Hotel Reservation</title>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />

    <style>
        .inline {
            display:inline-block !important;
        }
    </style>

    

</head>
<body>
    <h1 style="color: blue">My home away from home hotels</h1>
    <h4 style="color: gray">Where you&#39;re always treated like family</h4>
    <h2 style="color: blue">Please confirm your reservation request</h2>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblReservationResults" runat="server" Text=""></asp:Label>
    </div>
        <asp:Button ID="btnConfirmRequest" runat="server" Text="Confirm Request" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnModifyRequest" runat="server" Text="Modify Request" style="margin-left: 24px" />
    </form>
</body>
</html>
