<%@ Page Title="View Schools" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewSchools.aspx.cs" Inherits="Guest_ViewSchools" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Schools names and types</h3>
    <p></p>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>
