<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewTeachersAndRateThem.aspx.cs" Inherits="Parent_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="561px">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="365px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Rate" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
