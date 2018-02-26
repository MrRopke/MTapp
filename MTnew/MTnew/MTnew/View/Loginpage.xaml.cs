using System;
using System.Collections.Generic;
using MTnew.Models;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;

namespace MTnew.View
{
    public partial class Loginpage : ContentPage
    {
        public Loginpage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BaggroundColor;
            lbl_Username.TextColor = Constants.MainTextColor;
            lbl_Password.TextColor = Constants.MainTextColor;
            AcivitySpinner.IsVisible = false;
            LogoName.HeightRequest = Constants.LoginIconHeight;

            entry_Username.Completed += (s, e) => entry_Password.Focus();
            entry_Password.Completed += (s, e) => SignInProcced(s,e);

        }


        void SignInProcced(Object sender, EventArgs e)
        {
            Users user = new Users(entry_Username.Text, lbl_Password.Text);
            if (user.checkinformation())
            {
                DisplayAlert("Login", "Succes","OK");
                Navigation.PushModalAsync(new MainPage());

            }
            else
            {
                DisplayAlert("Login", "Username or Password incorrect", "OK");
            }
        }

    }
}
