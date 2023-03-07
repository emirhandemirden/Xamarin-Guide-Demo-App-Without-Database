using System;
using RehberApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RehberApp.Services;

namespace RehberApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Places : ContentPage {
        public Places() { 
            InitializeComponent();
            // Get the data
            Setup(); 
            // Change the background color with selected theme info
            if (MainPage.Theme == "Dark") { BackgroundColor = Color.Black; }
            else if (MainPage.Theme == "Light") { BackgroundColor = Color.White; }
            // You can make the language settings with the selected language
        }

        public static string choose = "";
        string language = MainPage.choose;
        private List<PlacesList> AllPlaces { get; set; }

        private List<PlacesList> GetList1() {
            return new List<PlacesList>() {
                new PlacesList{Name = "Kanyonlar"},
                new PlacesList{Name = "Şelaleler"},
                new PlacesList{Name = "Mağaralar"},
                new PlacesList{Name = "Müzeler"},
                new PlacesList{Name = "Restoranlar"}
            };
        }

        private void Setup() {
            AllPlaces = GetList1();
            PlacesList.ItemsSource = AllPlaces;
        }

        private async void Places_Clicked(object sender, EventArgs e) {
            choose = (sender as Button).Text;
            await Navigation.PushModalAsync(new Place());
            // Go to the next page but with the selected category
        }
    }
}