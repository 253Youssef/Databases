<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SchoolsAcceptedMyChild.aspx.cs" Inherits="Parent_SchoolsAcceptedMyChild" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Panel ID="Panel2" runat="server" Height="273px" style="text-align: center; font-size: xx-large; font-weight: 700; text-decoration: underline">
            Schools accepted my child:
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Apply" />
        </asp:Panel>

          

    </asp:Panel>
</asp:Content>

