<%@ Page Title="View Questions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewQuestions.aspx.cs" Inherits="ViewQues" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Go To Teacher's Home Page" />

    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="PlaceHolder4" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ccode" ID="label6" CssClass="col-md-2 control-label">Course Code: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ccode" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!-- Register Button -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="postg" runat="server" OnClick="buttonClick" Text="View Course Questions" CssClass="btn btn-default"/>
            </div>
        </div>
        <!-- End of Register Button -->
        
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="qid" ID="label1" CssClass="col-md-2 control-label">Question ID: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="qid" CssClass="form-control" />
            </div>
        </div>
        <!-- End of Division -->
        <!-- Register Button -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button1" runat="server" OnClick="goan" Text="Answer Question" CssClass="btn btn-default"/>
            </div>
        </div>
        <!-- End of Register Button -->
    </asp:PlaceHolder>
</asp:Content>
