<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.ViewModels.DinnerDetailsViewModel>" %>
<%@ Import Namespace="NerdDinner.Views" %>
<%@ Import Namespace="NerdDinner.Controllers" %>
<%@ Import Namespace="NerdDinner.Resources" %>

<asp:Content ID="Script" ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        function animateRsvpConfirmation() {
            $('#rsvpConfirmationDiv').animate({ fontSize: "1.5em" }, 400);
        }
    </script>
</asp:Content>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Dinner: <%:Model.Dinner.Title%>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%:Model.Dinner.Title%></h2>

    <p>
        <strong>When:</strong>
        <%=Model.Dinner.EventDate.ToShortDateString()%>

        <strong>@</strong>
        <%=Model.Dinner.EventDate.ToShortTimeString()%>
    </p>

    <p>
        <strong>Where:</strong>
        <%:Model.Dinner.Address%>,
        <%:Model.Dinner.Country.Name%>
    </p>

    <p>
        <strong>Description:</strong>
        <%:Model.Dinner.Description%>
    </p>

    <p>
        <strong>Organizer:</strong>
        <%:Model.Dinner.HostedBy%>
        (<%:Model.Dinner.ContactPhone%>)
    </p>

    <% Html.RenderPartial(ViewNames.Rsvp, Model); %>

    <% Html.RenderPartial(ViewNames.ModificationLinks, Model); %>

</asp:Content>
