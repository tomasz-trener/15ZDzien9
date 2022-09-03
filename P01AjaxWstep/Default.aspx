<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01AjaxWstep.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.6.1.min.js"></script>
    <script src="DefaultJS.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <p>Rozwiązanie synchroniczne</p>
            <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>
            <asp:Button ID="btnPolicz" OnClick="btnPolicz_Click" runat="server" Text="Policz" />
            <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>
        </div>

        <div>
            <p>Rozwiąznie asynchroniczne</p>
            <input type="text" id="txtLiczba1HTML" />
            <input type="text" id="txtLiczba2HTML" />
            <input type="button" value="Policz" id="btnPoliczHTML" />
            <span id="lblWynikHTML"></span>


        </div>

 
    </form>
</body>


</html>
