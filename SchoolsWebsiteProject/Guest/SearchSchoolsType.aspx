<%@ Page Title="Search Schools By Address" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SearchSchoolsType.aspx.cs" Inherits="Guest_ViewSchools" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tinput" ID="namelbl" CssClass="col-md-2 control-label">School Type:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tinput" CssClass="form-control" />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="buttonClick"/>
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
</asp:Content>
