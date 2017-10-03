using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
