using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Image = RehberApp.Models.Image;

namespace RehberApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceInfo : ContentPage {
        public PlaceInfo() {
            InitializeComponent();
            // Get the background color and set the color for items
            if (MainPage.Theme == "Dark") {
                BackgroundColor = Color.Black;
                Title.TextColor = Color.White;
                Description.TextColor = Color.White;
                ClosePlaces.TextColor = Color.White;
                Way.TextColor = Color.White;
            }
            else if (MainPage.Theme == "Light") {
                BackgroundColor = Color.White;
                Title.TextColor = Color.Black;
                Description.TextColor = Color.Black;
                ClosePlaces.TextColor = Color.Black;
                Way.TextColor = Color.Black;
            }
            List<Image> images = new List<Image>() {
                new Image() { Title="Image 1", Url="@android:drawable/image1" },
                new Image() { Title="Image 2", Url="@android:drawable/image2" }
            };
            // Get the description, close places and location link
            ClosePlaces.Text = "Yakın Yerler: " + "Örnek Restorant, Örnek Taksi, Örnek Yer";
            Description.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas bibendum diam ac leo mattis, sit amet ultrices lacus malesuada. Etiam blandit ipsum a lorem lobortis dapibus. Mauris sem felis, dapibus a sapien vel, accumsan gravida quam. Morbi dolor nunc, finibus a velit vitae, ullamcorper bibendum turpis. Nulla pretium condimentum consequat. Integer vulputate lectus vitae magna vehicula, non vulputate massa vestibulum. Nullam fringilla bibendum ipsum, a vulputate dolor. Donec nec erat eu metus accumsan aliquam.Duis vitae lectus nisi. Fusce consectetur dapibus enim non aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus.Sed nulla nulla, ultricies eget metus eget, euismod convallis eros. Aliquam sit amet odio sit amet massa blandit vestibulum nec id odio. Ut arcu nibh, vestibulum non imperdiet at, varius vehicula ante. Vivamus turpis lorem, pharetra sagittis imperdiet elementum, dictum sit amet nisi.Cras pulvinar laoreet orci euismod accumsan. Nullam sit amet nibh eu eros pellentesque egestas vitae non risus.Pellentesque aliquet feugiat tincidunt. Quisque sit amet blandit ex.";
            Carousel.ItemsSource = images;
        }

        private async void Way_Clicked(object sender, EventArgs e) {
            // You can add here the link of the place
            await Browser.OpenAsync(""); 
        }
    }
}