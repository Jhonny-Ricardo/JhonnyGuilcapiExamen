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
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = IblUser.Text;
            IblUser.Text = usuario + user;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            int montoI = int.Parse(monto.Text);
            if (montoI < 1800 && montoI > 0)
            {
                int pagoMensual = 1800 - montoI;
                Double pagoTotal = (((pagoMensual / 3) *0.05)+ (pagoMensual / 3));
                string valor = Convert.ToString(pagoTotal);
                await DisplayAlert("Alerta", valor, "OK");
            }
            else
            {
                await DisplayAlert("Pago Mnesual","Error", "OK");
            }
             
        }

    }
    }