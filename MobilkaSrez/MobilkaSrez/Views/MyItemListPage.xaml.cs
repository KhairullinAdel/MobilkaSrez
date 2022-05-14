using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MobilkaSrez.Models;

namespace MobilkaSrez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyItemListPage : ContentPage
    {
        public List<MyItem> Items { get; set; }
        public MyItemListPage()
        {
            InitializeComponent();
            Items = App.Database.GetAllItems();
            BindingContext = this;
        }

    }
}