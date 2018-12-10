﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicab.Api.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unicab.App.DriverModule
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedUpcomingRidePage : ContentPage
	{
		public SelectedUpcomingRidePage (CabRequest upcomingRide)
		{
			InitializeComponent ();

            //this.Title = string.Format("{0} {1} {2}", upcomingRide.PickupLocation, char.ConvertFromUtf32(0x2197), upcomingRide.DropoffLocation);

            StatusLabel.Text = "ON SCHEDULE";
            RideFromLabel.Text = upcomingRide.PickUpLocation;
            RideToLabel.Text = upcomingRide.DropOffLocation;
            PickupDateLabel.Text = upcomingRide.PickUpDateTime.ToLongDateString();
            PickupTimeLabel.Text = upcomingRide.PickUpDateTime.ToShortTimeString();
            NoOfSeatsLabel.Text = upcomingRide.NoOfPassengers.ToString();
            LadiesOnlyLabel.Text = (upcomingRide.IsLadiesOnly) ? "Yes" : "No";
            AdditionalNotesLabel.Text = upcomingRide.AdditionalNotes;
        }

        private async void CallPassengerBtn_Clicked(object sender, EventArgs e)
        {
            bool continueNextSteps = await DisplayAlert("Call Passenger", "Are you sure you wish to call this passenger? Tap 'Yes' to proceed, or 'No' to go back.", "Yes", "No");
            if (continueNextSteps)
            {
                await DisplayAlert("Call Passenger", "Not implemented yet, sorry.", "OK");
            }
            else
            {

            }
        }

        private async void MessagePassengerBtn_Clicked(object sender, EventArgs e)
        {
            bool continueNextSteps = await DisplayAlert("Message Passenger", "Are you sure you wish to message this passenger? Tap 'Yes' to proceed, or 'No' to go back.", "Yes", "No");
            if (continueNextSteps)
            {
                await DisplayAlert("Message Passenger", "Not implemented yet, sorry.", "OK");
                
            }
            else
            {

            }
        }

    }
}