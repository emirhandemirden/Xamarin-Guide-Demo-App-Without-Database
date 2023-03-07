using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Firebase.Database.Query;
using System.Collections.ObjectModel;
using RehberApp.Models;

namespace RehberApp.Services {
    public class PlacesService {
        FirebaseClient client;
        public PlacesService() { client = new FirebaseClient("https://kastamonuguideapp-efcd4-default-rtdb.firebaseio.com/"); }
        public async Task<List<PlacesList>> GetPlacesListsAsync() {
            var categories = (await client.Child("Categories").OnceAsync<PlacesList>()).Select(f => new PlacesList {
                Name = f.Object.Name,
                LineNumber = f.Object.LineNumber,
                Status = f.Object.Status,
                PlacesID = f.Object.PlacesID
            }).ToList();
            return categories;
        }
        public async Task<List<PlacesList>> GetPlacesByActivationAsync() {
            var PlacesByActivation = new List<PlacesList>();
            var items = (await GetPlacesListsAsync()).Where(p => p.Status == "Active").OrderByDescending(f => f.LineNumber).ToList();
            foreach (var item in items) { PlacesByActivation.Add(item); }
            return PlacesByActivation;
        }
    }
}