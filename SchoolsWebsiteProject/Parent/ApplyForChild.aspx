<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ApplyForChild.aspx.cs" Inherits="Parent_ApplyForChild" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="314px" style="text-align: center">
        <strong><em><span style="font-size: xx-large; text-align: left">Apply for my child<br /> </span>
        <asp:Panel ID="Panel2" runat="server" Height="122px" style="text-align: justify">
            <br />
            SSN:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Name:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Birthdate:&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Gender:
            <asp:TextBox ID="TextBox4" runat="server" Width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="School name:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Apply" />
        </asp:Panel>
        </em></strong>
    </asp:Panel>
</asp:Content>

