using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MTnew.ViewModels;
using MTnew.Models;


namespace MTnew.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetails : ContentPage
    {        
        RecipeViewModel viewModel;
        public int RidToDelete = 0;

        public RecipeDetails()
        { 
            InitializeComponent();
            
        }
        //a constructor who get information from the list.
        public RecipeDetails(RecipeViewModel viewModel, int rid)
        {
            InitializeComponent();
            RidToDelete = rid;
            BindingContext = this.viewModel = viewModel;
            
        }

        //Getting back to the mainpage
        void Backvoid(object sender, EventArgs args)
        {
            //await NavigationPage(new MTnew.MainPage());
            //await Navigation.PushModalAsync(new MainPage());
            Navigation.PopModalAsync();
        }

        public void DeleteBTN()
        {
            MainPage mp = new MainPage();
            DeleteAsync(RidToDelete);
            Navigation.PopModalAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var client = new System.Net.Http.HttpClient();
            var address = $"http://mrropke-001-site1.gtempurl.com/api/retters/{id}";            
            var uri = new Uri(string.Format(address, id));            
            var response = await client.DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Deleted", "The recipe is deleted", "OK");
            }
            
        }
    }
}