<%@ Page Title="Parent Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ParentRegistration.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new parent account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ssn" id="label1" CssClass="col-md-2 control-label">SSN</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ssn" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" id="labelfname" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="MiddleName" id="label2" CssClass="col-md-2 control-label">Middle Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="MiddleName" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" id="label3" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="email" id="label4" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="email" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="mobile" id="label5" CssClass="col-md-2 control-label">Mobile Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="mobile" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="address" id="label6" CssClass="col-md-2 control-label">Address</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="address" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Homephone" id="label7" CssClass="col-md-2 control-label">Home Phone Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Homephone" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="username" id="label8" CssClass="col-md-2 control-label">Username</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="username" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="password" id="label9" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="password" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->

        <!-- Register Button -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
        <!-- End of Register Button -->
    </div>
</asp:Content>

