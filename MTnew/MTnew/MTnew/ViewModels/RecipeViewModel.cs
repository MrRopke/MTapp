using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTnew.Models;
using MTnew.View;
using MTnew.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTnew.ViewModels
{
    public class RecipeViewModel : ContentPage
    {
        public Recipes Rec { get; set; }

        public RecipeViewModel(Recipes recipe = null)
        {
            Rec = recipe;

        }


    }
}
