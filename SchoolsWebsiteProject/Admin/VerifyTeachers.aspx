<%@ Page Title="Verify Teachers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="VerifyTeachers.aspx.cs" Inherits="Guest_ViewSchools" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="username" id="labeluname" CssClass="col-md-2 control-label">UserName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="username" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="password" id="label1" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="password" CssClass="form-control" />
                 </div>
            <asp:Button ID="Verify" runat="server" Text="Verify" OnClick="buttonClick" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
