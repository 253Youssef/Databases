<%@ Page Title="View Assignments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewGradeAssig.aspx.cs" Inherits="ViewAss" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go To Teacher's Home Page" />

    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="suser" ID="label6" CssClass="col-md-2 control-label">Student Username: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="suser" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="assid" ID="label1" CssClass="col-md-2 control-label">Assignment ID: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="assid" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ccode" ID="label2" CssClass="col-md-2 control-label">Course Code: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ccode" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->

        <!-- Register Button -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="buttonClick" Text="View Student's Solution" CssClass="btn btn-default" />
            </div>
        </div>
        <!-- End of Register Button -->
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder3" runat="server">
        
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder4" runat="server">
        <!-- Register Button -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="postg" runat="server" OnClick="gopg" Text="Post Student's Grade" CssClass="btn btn-default"/>
            </div>
        </div>
        <!-- End of Register Button -->
    </asp:PlaceHolder>
</asp:Content>
