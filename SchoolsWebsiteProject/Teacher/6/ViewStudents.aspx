<%@ Page Title="List Of Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewStudents.aspx.cs" Inherits="Teacher" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Welcome</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go To Teacher's Home Page" />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
    </div>
</asp:Content>

