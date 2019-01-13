<%@ Page Title="PostAnnouncements" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="PostAnnouncements.aspx.cs" Inherits="Admin_PostAnnouncements" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="title" id="label3" CssClass="col-md-2 control-label">Date</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="date" CssClass="form-control" />
                 </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="description" id="labeluname" CssClass="col-md-2 control-label">Description</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="description" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="title" id="label1" CssClass="col-md-2 control-label">Title</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="title" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="type" id="label2" CssClass="col-md-2 control-label">Type</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="type" CssClass="form-control" />
                 </div>

            <asp:Button ID="Post" runat="server" Text="Verify" OnClick="buttonClick" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
