using RehberApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RehberApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Place : ContentPage {
        public Place() { 
            InitializeComponent();
            // Get the background color
            if (MainPage.Theme == "Dark") { BackgroundColor = Color.Black; }
            else if (MainPage.Theme == "Light") { BackgroundColor = Color.White; }
            // Get the data
            Setup(); 
        }

        string places = Places.choose;
        public static string choose = "";
        private List<PlaceList> AllPlace { get; set; }

        private List<PlaceList> GetList() {
            return new List<PlaceList>() {
                new PlaceList{PlaceName = "Çatak Kanyonu", TextColor="White", BackGroundColor="DodgerBlue"},
                new PlaceList{PlaceName = "Valla Kanyonu", TextColor="White", BackGroundColor="DodgerBlue"},
                new PlaceList{PlaceName = "Horma Kanyonu", TextColor="White", BackGroundColor="DodgerBlue"}
            };
        }
        private void Setup() {
            AllPlace = GetList();
            PlaceList.ItemsSource = AllPlace;
        }

        private async void Place_Clicked(object sender, EventArgs e) {
            choose = (sender as Button).Text;
            await Navigation.PushModalAsync(new PlaceInfo());
            // go to Placeİnfo with the selected place
        }
    }
}