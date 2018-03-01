using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MTnew.Models;
using MTnew.View;
using MTnew.ViewModels;
using Newtonsoft.Json;
using System.Net.Http;


namespace MTnew.View
{
    public partial class Addpage : ContentPage
    {
        public Addpage()
        {
            InitializeComponent();
        }

        //The api connection
        public async Task PostRecipe(Recipes recipee)
        {
            var client = new System.Net.Http.HttpClient();
            var address = $"http://mrropke-001-site1.gtempurl.com/api/retters";
            var uri = new Uri(string.Format(address, string.Empty));
            var json = JsonConvert.SerializeObject(recipee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;

            response = await client.PostAsync(uri, content);

            //If there is no respond to the api
            if (!response.IsSuccessStatusCode)
            {
                await DisplayAlert("Error", "The server doesn't respond", "OK");
            }
        }

        //Putting the information from the app in to the api/server
        void AddButton (object sender, EventArgs e)
        {
            Recipes recipee = new Recipes(Entry_Overskrift.Text, Entry_Beskrivelse.Text, 1 );


            //If there i nothing in the entry field in the app
            if (!recipee.CheckInformation())
            {
                DisplayAlert("The dish", "You need a headline", "OK");
                BTN_AddDish.BackgroundColor = Color.Gray;

            }
            //If there is information in the entry
            else if (recipee.CheckInformation())
            {
                var result = DisplayAlert("The dish", "The dish is added", null, "Ok");
                PostRecipe(recipee);
                Navigation.PushModalAsync(new MainPage());
            }
        }

        //Getting back to the mainpage
        void Backvoid(object sender, EventArgs args)
        {
            //await NavigationPage(new MTnew.MainPage());
            //await Navigation.PushModalAsync(new MainPage());
            Navigation.PopModalAsync();
        }

        //if the information in the entry are change.
        void Overskrift_Change(object sender, TextChangedEventArgs e)
        {
            if (!Entry_Overskrift.Text.Equals("Write here"))
            {
                BTN_AddDish.BackgroundColor = Color.MediumSpringGreen;
            }
            else if (Entry_Overskrift.Text.Contains(""))
            {
                BTN_AddDish.BackgroundColor = Color.Gray;
            }

        }
    }
}
