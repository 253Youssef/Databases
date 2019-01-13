<%@ Page Title="Post Assignment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="PostAss.aspx.cs" Inherits="PostAss" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go To Teacher's Home Page" />

    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="dateinput" ID="namelbl" CssClass="col-md-2 control-label">Posting Date: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="dateinput" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="dueinput" ID="Label1" CssClass="col-md-2 control-label">Due Date: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="dueinput" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="codeinput" ID="Label2" CssClass="col-md-2 control-label">Course: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="codeinput" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="contentinput" ID="Label3" CssClass="col-md-2 control-label">Content: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox id="contentinput" runat="server" TextMode="MultiLine"></asp:TextBox>

               <!-- <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" /> -->
            </div>
        </div>
        <!-- End of Division -->



        <asp:Button ID="Button1" runat="server" Text="Post Assignment!" OnClick="buttonClick"/>
    </asp:PlaceHolder>
</asp:Content>
