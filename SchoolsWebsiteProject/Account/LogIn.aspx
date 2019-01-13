<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="Account_Login" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Please select one of the following</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Account/StudentLogIn">I'm a Student</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Account/ParentLogIn">I'm a Parent</asp:HyperLink>
        <br /> 
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Account/TeacherLogIn">I'm a Teacher</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="/Account/AdminLogIn">I'm a School Administrator</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="/Account/sysAdminLogIn">I'm a System Administrator</asp:HyperLink>
        <br />
        
    </div>
</asp:Content>

