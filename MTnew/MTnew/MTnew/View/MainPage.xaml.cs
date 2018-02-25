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


namespace MTnew
{
    public partial class MainPage : ContentPage
    {
        public List<Recipes> Opskriftsliste = new List<Recipes>();

        public int UserId = 1;

        public MainPage()
        {
            InitializeComponent();
            GetRecipesAsync(UserId);


            //lavopskrift(1, "Karry ret", "- Karry");
            //lavopskrift(2, "Kokos ret", "- Kokos");
            //lavopskrift(3, "Lasagne", "- Lasagne pladder");            
            //Opliste.ItemsSource = Opskriftsliste;

            //Opskriftsliste.Add(new Recipes() { Rid = 1, Overskrift = "Mads Boller i Karry", Indhold = "- Karry og boller" });


        }
        //Connetion for the api
        public async Task GetRecipesAsync(int id)
        {
            var client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var address = $"http://mrropke-001-site1.gtempurl.com/api/retters/{id}";
            var response = await client.GetAsync(address);
            var CoinJson = response.Content.ReadAsStringAsync().Result;
            Opskriftsliste = JsonConvert.DeserializeObject<List<Recipes>>(CoinJson);

            Opliste.ItemsSource = Opskriftsliste;
        }
            //If a recipe is pushed, this will make you to the recipedetails.
            private async void MyRecipeTapped(object sender, ItemTappedEventArgs e)
        {
            var recipee = e.Item as Recipes;
            await Navigation.PushModalAsync(new RecipeDetails(new RecipeViewModel(recipee)));
        }


        //public void lavopskrift(int id, string overskrift, string indhold)
        //{
        //    Recipes rc = new Recipes();
        //    rc.Rid = id;
        //    rc.Overskrift = overskrift;
        //    rc.Indhold = indhold;
        //    Opskriftsliste.Add(rc);
        //}

        //Getting to the addpage
        void AddPage(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Addpage());
        }
    }
}
