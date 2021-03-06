﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicab.Api.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unicab.App.PM.CP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CPFulfillmentListPage : ContentPage
	{
        public ObservableCollection<CarpoolOfferFulfillment> Items { get; set; }

        public CPFulfillmentListPage()
        {
            InitializeComponent();

            AvailableCPListView.RefreshCommand = new Command(async () =>
            {
                await RefreshData();
                AvailableCPListView.IsRefreshing = false;
            });

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await RefreshData();

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new CPFulfillmentPage(e.Item as CarpoolOfferFulfillment));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async Task RefreshData()
        {
            var carpoolOffersList = await App.CarpoolManager.GetAvailableCarpoolOfferFulfillmentsByPassengerId(App.CurrentPassenger.PassengerId);

            Items = new ObservableCollection<CarpoolOfferFulfillment>(carpoolOffersList);

            AvailableCPListView.ItemsSource = Items;
        }
    }
}