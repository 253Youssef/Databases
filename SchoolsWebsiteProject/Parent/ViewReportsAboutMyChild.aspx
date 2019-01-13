<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewReportsAboutMyChild.aspx.cs" Inherits="Parent_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="328px">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="82px" Width="303px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="119px" Width="418px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="reply" OnClick="Button1_Click" />
            <br />
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
