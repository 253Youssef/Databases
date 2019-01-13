<%@ Page Title="EditSchool" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="EditSchool.aspx.cs" Inherits="Admin_EditSchool" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="nname" id="labeluname" CssClass="col-md-2 control-label">NewName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="nname" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="address" id="label1" CssClass="col-md-2 control-label">Address</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="address" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="phone" id="label2" CssClass="col-md-2 control-label">Phone</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="phone" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="email" id="label3" CssClass="col-md-2 control-label">email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="email" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="info" id="label4" CssClass="col-md-2 control-label">Information</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="info" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="vision" id="label5" CssClass="col-md-2 control-label">Vision</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="vision" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="mission" id="label6" CssClass="col-md-2 control-label">Mission</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="mission" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="lang" id="label7" CssClass="col-md-2 control-label">MainLanguage</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="lang" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="type" id="label8" CssClass="col-md-2 control-label">Type</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="type" CssClass="form-control" />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="fee" id="label9" CssClass="col-md-2 control-label">Fees</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="fee" CssClass="form-control" />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="b_grade" id="label10" CssClass="col-md-2 control-label">BeginGrade</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="b_grade" CssClass="form-control" />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="e_grade" id="label11" CssClass="col-md-2 control-label">EndGrade</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="e_grade" CssClass="form-control" />

            <asp:Button ID="Change" runat="server" Text="Verify" OnClick="buttonClick" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
