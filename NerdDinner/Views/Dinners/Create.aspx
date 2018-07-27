<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.ViewModels.DinnerFormViewModel>" %>
<%@ Import Namespace="NerdDinner.Views" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Host a Dinner
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Host a Dinner</h2>
    <% Html.RenderPartial(ViewNames.Form); %>
</asp:Content>

