<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="NerdDinner.Controllers" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Dinner Deleted
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Dinner Deleted</h2>

    <div>
        <p>Your dinner was successfully deleted.</p>
    </div>

    <div>
        <p>
            <%= Html.ActionLink("Click for Upcoming Dinners", ActionNames.Index) %>
         </p>
    </div>

</asp:Content>
