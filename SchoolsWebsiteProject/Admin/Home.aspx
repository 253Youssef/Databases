<%@ Page Title="Admin Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Admin_Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1></h1>
        <asp:PlaceHolder ID="adminname" runat="server"></asp:PlaceHolder>
        <p class="lead">Teacher Home</p>
        <asp:HyperLink ID="VerifyTeachers" runat="server" NavigateUrl="/Admin/VerifyTeachers.aspx">Verify Teachers</asp:HyperLink>
        <br />
        <asp:HyperLink ID="AcceptOrReject" runat="server" NavigateUrl="/Admin/AcceptOrReject.aspx">Accept OR Reject</asp:HyperLink>
        <br />
        <asp:HyperLink ID="VerifyStudents" runat="server" NavigateUrl="/Admin/VerifyStudents.aspx">Verify Students</asp:HyperLink>
        <br />
        <asp:HyperLink ID="EditSchool" runat="server" NavigateUrl="/Admin/EditSchool.aspx">Edit Schools</asp:HyperLink>
        <br />
        <asp:HyperLink ID="PostAnnouncements" runat="server" NavigateUrl="/Admin/PostAnnouncements.aspx">Post Announcements</asp:HyperLink>
        <br />
        <asp:HyperLink ID="CreateAndAssign" runat="server" NavigateUrl="/Admin/CreateAndAssign.aspx">Create And Assign</asp:HyperLink>
        <br />
        <asp:HyperLink ID="AssignTeachersToCourses" runat="server" NavigateUrl="/Admin/AssignTeachersToCourses.aspx">Assign Teachers To Courses</asp:HyperLink>
        <br />
        <!-- <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p> -->
    </div>

    <!-- <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div> -->
</asp:Content>
