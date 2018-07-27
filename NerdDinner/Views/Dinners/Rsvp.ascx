<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<NerdDinner.ViewModels.DinnerDetailsViewModel>" %>
<%@ Import Namespace="NerdDinner.Models" %>
<%@ Import Namespace="NerdDinner.Resources" %>
<%@ Import Namespace="NerdDinner.Controllers" %>

<% 
    if (Request.IsAuthenticated) {
            
        if (Model.UserHasRsvp) 
        {
%>       
            <p>You are registred for this event!</p>
<% 
        } 
        else
        { 
%> 
            <div id="rsvpConfirmationDiv" />

            <%= Ajax.ActionLink(
                Messages.Rsvp, ActionNames.Rsvp, ControllerNames.Rsvp,
                new { dinnerID = Model.Dinner.DinnerID },
                new AjaxOptions { UpdateTargetId = "rsvpConfirmationDiv",
                                    OnSuccess = "animateRsvpConfirmation" })%>
<%      
        }
    }
    else 
    { 
%>
        <a href="/Account/Logon">Logon</a> to RSVP for this event.
<% 
    } 
%>