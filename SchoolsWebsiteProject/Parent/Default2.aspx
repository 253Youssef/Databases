<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="260px" style="text-align: center" Width="642px">
        <asp:Label ID="Label1" runat="server" Text="Parent Page" style="font-size: xx-large; font-weight: 700"></asp:Label>
        <br />
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="ApplyForChild.aspx" Text="Apply for my child" Value="Apply for my child"></asp:MenuItem>
            </Items>
        </asp:Menu>

    </asp:Panel>
</asp:Content>

