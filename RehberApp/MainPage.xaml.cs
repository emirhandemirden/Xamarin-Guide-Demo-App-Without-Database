using RehberApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RehberApp {
    public partial class MainPage : ContentPage {
        public static string Theme = "Light";
        public MainPage() { 
            InitializeComponent();
            // Get the background picture
            BackgroundImageSource = "@android:drawable/bg2.png";
            // Get the picture info for selected theme
            if (Theme == "Dark") { ThemeButton.Source = "@android:drawable/sun.png"; }
            else if (Theme == "Light") { ThemeButton.Source = "@android:drawable/moon.png"; }
        }

        public static string choose = "";

        private async void Turkish_Clicked(object sender, EventArgs e) {
            // Countinue with Turkish
            choose = "Turkish";
            await Navigation.PushModalAsync(new Places());
        }

        private async void English_Clicked(object sender, EventArgs e) {
            // Countinue with English
            choose = "English";
            await Navigation.PushModalAsync(new Places());
        }

        private void ThemeButton_Clicked(object sender, EventArgs e) {
            if (Theme == "Dark") {
                // Change The Theme Info as Light on Database
                ThemeButton.Source = "@android:drawable/moon.png";
                Theme = "Light";
            }
            else if (Theme == "Light") {
                // Change The Theme Info as Dark on Database
                ThemeButton.Source = "@android:drawable/sun.png";
                Theme = "Dark";
            }
        }
    }
}
