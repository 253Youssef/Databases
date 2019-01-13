<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Please select one of the following</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Account/StudentRegistration">I'm a Student</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Account/ParentRegistration">I'm a Parent</asp:HyperLink>
        <br /> 
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Account/TeacherRegistration">I'm a Teacher</asp:HyperLink>
        <br />
        
    </div>
</asp:Content>

