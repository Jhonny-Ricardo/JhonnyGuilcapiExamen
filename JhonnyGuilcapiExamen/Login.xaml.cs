using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonnyGuilcapiExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            //Condicion
            if (user == "estudiante2020" && pass == "uisrael2020")
            {
                await Navigation.PushAsync(new Registro(user, pass));
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario incorrecto", "OK");
            }
        }
    }
}