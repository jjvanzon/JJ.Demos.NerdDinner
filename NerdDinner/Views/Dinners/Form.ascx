<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<NerdDinner.ViewModels.DinnerFormViewModel>" %>
<%@ Import Namespace="NerdDinner.Resources" %>
<%@ Import Namespace="NerdDinner.Models" %>

<% using (Html.BeginForm()) {%>

    <%: Html.ValidationSummary(Messages.PleaseCorrectErrors) %>
        
    <fieldset>
        <div class="editor-label">
            <%= Html.LabelFor(x => x.Dinner.Title) %>
        </div>
        <div class="editor-field">
            <%= Html.TextBoxFor(x => x.Dinner.Title)%>
            <%= Html.ValidationMessageFor(x => x.Dinner.Title, "*")%>
        </div>
            
        <div class="editor-label">
            <%= Html.LabelFor(x => x.Dinner.EventDate)%>
        </div>
        <div class="editor-field">
            <%= Html.TextBoxFor(x => x.Dinner.EventDate, String.Format("{0:g}", Model.Dinner.EventDate))%>
            <%= Html.ValidationMessageFor(x => x.Dinner.EventDate, "*")%>
        </div>
            
        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.Description)%>
        </div>
        <div class="editor-field">
            <%: Html.TextAreaFor(x => x.Dinner.Description)%>
            <%: Html.ValidationMessageFor(x => x.Dinner.Description, "*")%>
        </div>
                        
        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.Address)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(x => x.Dinner.Address)%>
            <%: Html.ValidationMessageFor(x => x.Dinner.Address, "*")%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.Country.CountryID)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(x => x.Dinner.Country.CountryID, new SelectList(Model.Countries, PropertyNames.CountryID, PropertyNames.Name))%>
            <%: Html.ValidationMessageFor(x => x.Dinner.Country, "*")%>
        </div>
            
        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.ContactPhone)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(x => x.Dinner.ContactPhone) %>
            <%: Html.ValidationMessageFor(x => x.Dinner.ContactPhone, "*")%>
        </div>
           
        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.Latitude)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(x => x.Dinner.Latitude)%>
            <%: Html.ValidationMessageFor(x => x.Dinner.Latitude, "*")%>
        </div>
            
        <div class="editor-label">
            <%: Html.LabelFor(x => x.Dinner.Longitude)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(x => x.Dinner.Longitude)%>
            <%: Html.ValidationMessageFor(x => x.Dinner.Longitude, "*")%>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
        
    <%: Html.HiddenFor(x => x.Dinner.DinnerID) %>
    <%: Html.HiddenFor(x => x.Dinner.HostedBy) %>

<% } %>
