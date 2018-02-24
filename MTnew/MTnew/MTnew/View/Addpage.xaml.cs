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
            Recipes recipes = new Recipes(Entry_Overskrift.Text, Entry_Beskrivelse.Text);


            if (Entry_Overskrift.Text == "Write here" || Entry_Overskrift.Text == "")
            {
                DisplayAlert("The dish", "You need a headline", "OK");
                BTN_AddDish.BackgroundColor = Color.Gray;
            }
            else if (Entry_Overskrift.Text != "Write here" || Entry_Overskrift.Text != "")
            {
                DisplayAlert("The dish", "The dish is added", "OK");

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
