<%@ Page Title="Search Schools" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SearchSchoolsName.aspx.cs" Inherits="Guest_ViewSchools" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="nameinput" ID="namelbl" CssClass="col-md-2 control-label">School Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="nameinput" CssClass="form-control" />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="buttonClick"/>
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
</asp:Content>
