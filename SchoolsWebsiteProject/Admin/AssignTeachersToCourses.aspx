<%@ Page Title="EditSchool" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AssignTeachersToCourses.aspx.cs" Inherits="Admin_AssignTeachersToCourses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:DropDownList ID="Teachers" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="Courses" runat="server"></asp:DropDownList>
            <asp:Button ID="Assign" runat="server" Text="Assign" OnClick="buttonClick" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
