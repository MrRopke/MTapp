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
                DisplayAlert("Oprettelse", "Retten er oprettet", "OK");
            }
            else
            {
                DisplayAlert("Oprettelse", "Overskriften er TOM!?", "OK");
            }

        }

    }
}
