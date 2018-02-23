using System;
using System.Collections.Generic;
using MTnew.View;
using Xamarin.Forms;
using MTnew.Models;

namespace MTnew.View
{
    public partial class Addpage : ContentPage
    {


        public Addpage()
        {
            InitializeComponent();
        }

        void AddButton (object sender, EventArgs e)
        {
            Recipes recipes = new Recipes(Lbl_Overskrift.Text, Lbl_beskrivelse.Text);


            if (recipes.CheckInformation())
            {
                DisplayAlert("The dish", "The dish is added", "OK");
            }
            else
            {
                DisplayAlert("The dish", "You need a headline", "OK");
            }
        }

        void Backvoid(object sender, EventArgs args)
        {
            //await NavigationPage(new MTnew.MainPage());
            //await Navigation.PushModalAsync(new MainPage());
            Navigation.PopModalAsync();
        }

        void Overskrift_Change(object sender, TextChangedEventArgs e)
        {
            if (!Entry_Overskrift.Equals("Write here"))
            {
                BTN_AddDish.BackgroundColor = Color.MediumSpringGreen;
            }
        }
    }
}
