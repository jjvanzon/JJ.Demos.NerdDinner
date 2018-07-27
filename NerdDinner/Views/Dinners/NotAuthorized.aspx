<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.ViewModels.NotAuthorizedViewModel>" %>
<%@ Import Namespace="NerdDinner.Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NotAuthorized
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>
        <%:Titles.NotAuthorized%>
    </h2>

    <p>
        <%:Model.Message%>
    </p>
</asp:Content>
