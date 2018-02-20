using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MTnew.ViewModels;

namespace MTnew.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetails : ContentPage
    {
        RecipeViewModel viewModel;
        
        public RecipeDetails()
        {
            InitializeComponent();
        }

        public RecipeDetails(RecipeViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
        public async void Backvoid()
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}