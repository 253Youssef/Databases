<%@ Page Title="EditSchool" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CreateAndAssign.aspx.cs" Inherits="Admin_CreateAndAssign" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="date" id="labeluname" CssClass="col-md-2 control-label">Date</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="date" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="description" id="label1" CssClass="col-md-2 control-label">Description</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="description" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="type" id="label2" CssClass="col-md-2 control-label">Type</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="type" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="location" id="label3" CssClass="col-md-2 control-label">Location</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="location" CssClass="form-control" />
                 </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="equipment" id="label4" CssClass="col-md-2 control-label">Equipment</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="equipment" CssClass="form-control" />
                 </div>
            <asp:DropDownList ID="Teachers" runat="server"></asp:DropDownList>
            <asp:Button ID="Assign" runat="server" Text="Assign" OnClick="buttonClick" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
