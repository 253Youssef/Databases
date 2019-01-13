<%@ Page Title="Student Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1></h1>
        <asp:PlaceHolder ID="StudentName" runat="server"></asp:PlaceHolder>
        <p class="lead">Student Home</p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Students/StudentViewInformation.aspx">View Own Info</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="/Students/StudentViewCourses.aspx">View Courses</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="/Students/StudentAskQuestions.aspx">Ask Questions</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="/Students/ViewQuestions.aspx">View Questions</asp:HyperLink>
         <br />
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="/Students/ViewAssignments.aspx">View Assignments</asp:HyperLink>
         <br />
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="/Students/ViewGrades.aspx">View Grades</asp:HyperLink>
         <br />
        <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="/Students/ViewClubs.aspx">View Clubs</asp:HyperLink>
         <br />
        <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="/Students/ViewActivities.aspx">View Activities</asp:HyperLink>
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
