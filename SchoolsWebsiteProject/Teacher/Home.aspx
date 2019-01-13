<%@ Page Title="Teacher Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1></h1>
        <asp:PlaceHolder ID="teachername" runat="server"></asp:PlaceHolder>
        <p class="lead">Teacher Home</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Teacher/1/ListOfCourses.aspx">View List Of Courses Ordered By Their Level, Then Grade</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Teacher/2/PostAss.aspx">Post Assginment</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Teacher/3/ViewGradeAssig.aspx">View my assignments</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="/Teacher/4/WriteReport.aspx">Write Reports</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="/Teacher/5/ViewQuestions.aspx">View and Answer Questions</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="/Teacher/6/ViewStudents.aspx">View My Students</asp:HyperLink>
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
