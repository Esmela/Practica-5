using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void btndatos_Clicked(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellidos = txtApellidos.Text;
            var direccion = txtdireccion.Text;
            var tel = txttelefono.Text;
            var mat = txtMatricula.Text;
            var carr = txtCarrera.Text;
            var sem = txtSemestre.Text;
            var mail = txtCorreo.Text;
            var git = txtGithub.Text;

            DisplayAlert("Datos", nombre + "\n" + apellidos + "\n" + direccion + "\n" + tel + "\n" + mat + "\n" + carr
                 + "\n" + sem + "\n" + mail + "\n" + git, "OK");

        }
        async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}