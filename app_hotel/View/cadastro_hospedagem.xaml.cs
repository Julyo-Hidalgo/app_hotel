using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_hotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastro_hospedagem : ContentPage
    {

        App propriedades_app;

        public cadastro_hospedagem()
        {
            InitializeComponent();

            propriedades_app = (App)Application.Current;

            pck_quarto.ItemsSource = propriedades_app.lista_suite;
        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {

        }
    }
}