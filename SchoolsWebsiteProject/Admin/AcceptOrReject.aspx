<%@ Page Title="AcceptOrReject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AcceptOrReject.aspx.cs" Inherits="Admin_AcceptOrReject" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ssn" id="labeluname" CssClass="col-md-2 control-label">ParentSSN</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ssn" CssClass="form-control" />
                 </div>
        </div>
        <!-- End of Division -->
        <!--Division Label and Form -->
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cssn" id="label1" CssClass="col-md-2 control-label">ChildSSN</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cssn" CssClass="form-control" />
                 </div>

            <asp:Button ID="Accept" runat="server" Text="Accept" OnClick="buttonClick" />
            <asp:Button ID="Reject" runat="server" Text="Reject" OnClick="buttonClick2" />
        </div>
        <!-- End of Division -->
    </asp:PlaceHolder>
    
</asp:Content>
