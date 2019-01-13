<%@ Page Title="Write Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="WriteReport.aspx.cs" Inherits="WriteReport" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Go To Teacher's Home Page" />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="dateinput" ID="namelbl" CssClass="col-md-2 control-label">Issue Date: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="dateinput" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
       
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="stun" ID="Label2" CssClass="col-md-2 control-label">Student Username: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="stun" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="comment" ID="Label3" CssClass="col-md-2 control-label">Teacher's Comment: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox id="comment" runat="server" TextMode="MultiLine"></asp:TextBox>

            </div>
        </div>
        <!-- End of Division -->

        <asp:Button ID="Button1" runat="server" Text="Submit Report" OnClick="buttonClick"/>
    </asp:PlaceHolder>
</asp:Content>
