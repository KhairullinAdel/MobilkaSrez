using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilkaSrez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyRegPage : ContentPage
    {
        public MyRegPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyAuthPage());
        }

        private async void RegButton_Clicked(object sender, EventArgs e)
        {
            var user = new Models.MyUser
            {
                Login = LoginField.Text,
                Password = PasswordField.Text,
                Uname = UnameField.Text
            };
            try
            {
                App.Database.AddUser(user);
                App.User = user;
                await Navigation.PushAsync(new MyItemListPage());
            }
            catch
            {
                await DisplayAlert("Ahtung", "This login is already used", "Close");
            }
        }
    }
}