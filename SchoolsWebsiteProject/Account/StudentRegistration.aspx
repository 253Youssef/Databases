<%@ Page Title="Student Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="StudentRegistration.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new student account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="parentusername" ID="labelparentname" CssClass="col-md-2 control-label">Parent Username</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="parentusername" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="parentpassword" ID="label1" CssClass="col-md-2 control-label">Parent Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="parentpassword" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cssn" ID="label2" CssClass="col-md-2 control-label">Child SSN</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cssn" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cname" ID="label3" CssClass="col-md-2 control-label">Child Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cname" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cbirth" ID="label4" CssClass="col-md-2 control-label">Child Birthdate</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cbirth" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cgender" ID="label5" CssClass="col-md-2 control-label">Child Gender</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cgender" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="sname" ID="label6" CssClass="col-md-2 control-label">School Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="sname" CssClass="form-control" />
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

