<%@ Page Title="Teacher Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="TeacherRegistration.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new teacher account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

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
            <asp:Label runat="server" AssociatedControlID="MiddleName" ID="labelmname" CssClass="col-md-2 control-label">Middle Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="MiddleName" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Lastname" ID="labellname" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Birthdate" ID="labelbdate" CssClass="col-md-2 control-label">Birthdate</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Birthdate" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Address" ID="labeladdress" CssClass="col-md-2 control-label">Address</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Address" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" ID="labelemail" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Gender" ID="labelgender" CssClass="col-md-2 control-label">Gender</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Gender" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="sName" ID="labelsname" CssClass="col-md-2 control-label">School Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="sName" CssClass="form-control" />
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

