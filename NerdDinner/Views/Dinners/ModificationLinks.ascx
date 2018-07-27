<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<NerdDinner.ViewModels.DinnerDetailsViewModel>" %>
<%@ Import Namespace="NerdDinner.Resources" %>
<%@ Import Namespace="NerdDinner.Controllers" %>


<% if (Model.ModificationIsAllowed)
    { %>
        <%= Html.ActionLink(Titles.EditDinner, ActionNames.Edit, new { id = Model.Dinner.DinnerID })%> |
        <%= Html.ActionLink(Titles.DeleteDinner, ActionNames.Delete, new { id = Model.Dinner.DinnerID })%>
<% } %>