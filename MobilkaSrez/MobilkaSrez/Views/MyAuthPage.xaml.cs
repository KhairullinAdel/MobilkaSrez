using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using MobilkaSrez.Models;

namespace MobilkaSrez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAuthPage : ContentPage
    {
        public MyAuthPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyRegPage());
        }

        private async void AuthButton_Clicked(object sender, EventArgs e)
        {
            var user = new MyUser()
            {
                Login = Login.Text,
                Password = Password.Text,
            };

            try
            {
                if (App.Database.UserIsCorrect(user))
                {
                    App.User = user;
                    await Navigation.PushAsync(new MyItemListPage());
                }
            }
            catch
            {
                await DisplayAlert("Ahtung", "Try again, Dude", "Okay");
            }
        }
    }
}