using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;
using NerdDinner.Repositories;

namespace NerdDinner.ViewModels
{
    public static class DinnerViewModelExtensions
    {
        public static Dinner ToModel(this DinnerViewModel viewModel, NerdDinnerDataContext dataContext)
        {
            if (viewModel == null) throw new ArgumentNullException("viewModel");
            if (dataContext == null) throw new ArgumentNullException("dataContext");

            var dinnerRepository = new DinnerRepository(dataContext);
            var countryRepository = new CountryRepository(dataContext);

            Dinner model = dinnerRepository.TryGetDinner(viewModel.DinnerID) ?? new Dinner();

            model.Address = viewModel.Address;
            model.ContactPhone = viewModel.ContactPhone;
            model.Description = viewModel.Description;
            model.EventDate = viewModel.EventDate;
            model.Latitude = viewModel.Latitude;
            model.Longitude = viewModel.Longitude;
            model.Title = viewModel.Title;
            model.HostedBy = viewModel.HostedBy;
            model.Country = viewModel.Country != null ? countryRepository.GetCountry(viewModel.Country.CountryID) : null;

            return model;
        }
    }
}