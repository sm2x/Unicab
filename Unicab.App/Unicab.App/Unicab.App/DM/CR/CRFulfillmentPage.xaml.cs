﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicab.Api.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unicab.App.DM.CR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CRFulfillmentPage : ContentPage
	{
        private CabRequestFulfillment selectedCRFulfillment;
        private CabRequest selectedCR;

        public CRFulfillmentPage(CabRequestFulfillment fulfillment)
        {
            InitializeComponent();
            selectedCRFulfillment = fulfillment;

            BindingContext = selectedCRFulfillment;

            selectedCR = selectedCRFulfillment.CabRequest;

            FullName.Text = string.Format("{0} {1}", selectedCR.Passenger.FirstName, selectedCR.Passenger.LastName);

        }

        private async void CompleteRideBtn_Clicked(object sender, EventArgs e)
        {
            bool confirmAccept = await DisplayAlert("Complete Cab Ride", "Complete this cab ride?", "Yes", "No");
            if (!confirmAccept)
                return;

            // accept the request

            await Navigation.PushAsync(new CRCompletedPage(selectedCRFulfillment));
        }
    }
}