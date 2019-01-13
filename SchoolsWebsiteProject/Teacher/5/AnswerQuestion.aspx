<%@ Page Title="Post Answer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AnswerQuestion.aspx.cs" Inherits="ViewAss" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Go To Teacher's Home Page" />

    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="answer" ID="label6" CssClass="col-md-2 control-label">Answer: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="answer" TextMode="MultiLine" CssClass="form-control" />
                <asp:Button ID="Button1" OnClick="buttonClick" runat="server" Text="Post Answer!" />
            </div>
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
