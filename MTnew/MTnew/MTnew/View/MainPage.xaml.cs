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

namespace MTnew
{
    public partial class MainPage : ContentPage
    {
        public List<Recipes> Opskriftsliste = new List<Recipes>();        

        public MainPage()
        {
            InitializeComponent();
            lavopskrift(1, "Karry ret", "- Karry");
            lavopskrift(2, "Kokos ret", "- Kokos");
            lavopskrift(3, "Lasagne", "- Lasagne pladder");            
            Opliste.ItemsSource = Opskriftsliste;

            //Opskriftsliste.Add(new Recipes() { Rid = 1, Overskrift = "Mads Boller i Karry", Indhold = "- Karry og boller" });

        }

        private async void MyRecipeTapped(object sender, ItemTappedEventArgs e)
        {
            var recipee = e.Item as Recipes;
            await Navigation.PushModalAsync(new RecipeDetails(new RecipeViewModel(recipee)));
        }

        public void lavopskrift(int id, string overskrift, string indhold)
        {
            Recipes rc = new Recipes();
            rc.Rid = id;
            rc.Overskrift = overskrift;
            rc.Indhold = indhold;
            Opskriftsliste.Add(rc);
        }

    }
}
