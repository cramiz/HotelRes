<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationForm.aspx.cs" Inherits="_Default" %>

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

    <script>
        $(function () {
            $("#txtboxArrival").datepicker({
                showOn: "button",
                buttonImage: "../Images/Calendar.bmp",
                buttonImageOnly: true,
            });
        });
    </script>

</head>
<body>
<form id="registration" runat="server">

    <h1 style="color: blue">My home away from home hotels</h1>
    <h4 style="color: gray">Where you&#39;re always treated like family</h4>

    <label for="txtboxArrival">Arrival date:</label>
    <asp:TextBox ID="txtboxArrival" runat="server" autofocus="true" Style="margin-right: 5px; margin-bottom: 5px"></asp:TextBox>
    <br />

    <label for="txtboxNights">Number of nights:</label>
    <asp:TextBox ID="txtboxNights" runat="server" Width="40px" Style="margin-bottom: 5px"></asp:TextBox>
    <br />

    <label for="ddlAdults">Adults:</label>
    <asp:DropDownList ID="ddlAdults" runat="server"></asp:DropDownList>

    <label for="ddlChildren">Children:</label>
    <asp:DropDownList ID="ddlChildren" runat="server"></asp:DropDownList>

    <h3 style="color: blue">Preferences:</h3>

    <span>Room Type:</span>
    <asp:RadioButtonList ID="rbtnRoom" runat="server" RepeatDirection="Horizontal" CssClass="inline">
        <asp:ListItem>Business</asp:ListItem>
        <asp:ListItem>Suite</asp:ListItem>
        <asp:ListItem>Standard</asp:ListItem>
    </asp:RadioButtonList>
    <br />

    <span>Bed Type:</span>
    <asp:RadioButtonList ID="rbtnBed" runat="server" RepeatDirection="Horizontal" CssClass="inline">
        <asp:ListItem>King</asp:ListItem>
        <asp:ListItem>Double</asp:ListItem>
    </asp:RadioButtonList>
    <br /><br />

    <asp:CheckBox ID="chkSmoking" runat="server" />
    <label for="chkSmoking">Smoking</label>
    <br /><br />

    <label for="txtboxSpecial">Special Requests:</label><br />
    <asp:TextBox ID="txtboxSpecial" runat="server" Rows="4" TextMode="MultiLine"></asp:TextBox>
    <br />

    <h3 style="color: blue">Contact Information:</h3>

    <label for="txtName">Name:</label>
    <asp:TextBox ID="txtName" runat="server" style="margin-left: 34px" Width="200px"></asp:TextBox>
    <br />
    
      

    <label for="txtEmail">Email:</label>
    <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 63px" Width="200px"></asp:TextBox>
    <br /><br />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Submit_Click" PostBackUrl="../ReservationFormResult.aspx" />
    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="Clear_Click" style="margin-left: 32px" />
    <br /><br />
    <a href="../ReservationManagerStarterFile.aspx">Reservation Manager</a>

   
</form>
</body>
</html>
