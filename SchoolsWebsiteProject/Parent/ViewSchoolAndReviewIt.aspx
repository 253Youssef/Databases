<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewSchoolAndReviewIt.aspx.cs" Inherits="Parent_ViewSchoolAndReviewIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="454px">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="365px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Review" OnClick="Button1_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
