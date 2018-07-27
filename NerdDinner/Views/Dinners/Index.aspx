<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.ViewModels.DinnersIndexViewModel>" %>
<%@ Import Namespace="NerdDinner" %>
<%@ Import Namespace="NerdDinner.Resources" %>
<%@ Import Namespace="NerdDinner.Views" %>
<%@ Import Namespace="NerdDinner.Controllers" %>
<%@ Import Namespace="NerdDinner.ViewModels" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Titles.UpcomingDinners %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Titles.UpcomingDinners %></h2>

    <ul>
        <% foreach (DinnerViewModel x in Model.Items) { %>
            
            <li>
                <%= Html.ActionLink(x.Title, ActionNames.Details, new { id = x.DinnerID }) %>
                on
                <%: x.EventDate.ToShortDateString() %>
                @
                <%: x.EventDate.ToShortTimeString() %>
            </li>

        <% } %>
    </ul>

    <% if (!Model.Pager.IsFirstPage) { %>

        <%--<%= Html.RouteLink("<", RouteNames.UpcomingDinners, new { pageIndex = Model.Pager.PageIndex - 1}) %>--%>

        <%= Html.ActionLink("<", ActionNames.Index, new { pageIndex = Model.Pager.PageIndex - 1}) %>

    <% } %>

    <% if (!Model.Pager.IsLastPage) { %>

        <%--<%= Html.RouteLink(">", RouteNames.UpcomingDinners, new { pageIndex = Model.Pager.PageIndex + 1 }) %>--%>

        <%= Html.ActionLink(">", ActionNames.Index, new { pageIndex = Model.Pager.PageIndex + 1 })  %>

    <% } %>

</asp:Content>

