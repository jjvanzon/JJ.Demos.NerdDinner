using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;
using NerdDinner.Repositories;

namespace NerdDinner.ViewModels
{
    public static class DinnerExtensions
	{
        public static DinnerViewModel ToViewModel(this Dinner model)
        {
            if (model == null) throw new ArgumentNullException("model");

            return new DinnerViewModel
            {
                DinnerID = model.DinnerID,
                Address = model.Address,
                ContactPhone = model.ContactPhone,
                Description = model.Description,
                EventDate = model.EventDate,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Title = model.Title,
                HostedBy = model.HostedBy,
                Country = model.Country != null ? model.Country.ToViewModel() : null
            };
        }
	}
}