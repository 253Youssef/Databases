<%@ Page Title="Search Schools" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="searchschool.aspx.cs" Inherits="Guest_searchschool" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Please select one of the following</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Guest/SearchSchoolsName">Search By Name</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Guest/SearchSchoolsType">Search By Type</asp:HyperLink>
        <br /> 
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Guest/SearchSchoolAddress">Search By Address</asp:HyperLink>
        <br />
        
    </div>
</asp:Content>

