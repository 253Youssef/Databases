<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewSchool.aspx.cs" Inherits="Parent_ReviewSchool" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="517px">
            <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="380px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="215px" Width="391px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Review" OnClick="Button1_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
