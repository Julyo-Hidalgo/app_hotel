using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

namespace app_hotel
{
    public partial class App : Application
    {
        public List<Model.dados> lista_suite = new List<Model.dados>(){
            new Model.dados()
            {
                descricao = "Suíte Super Luxuosa",
                valor_diaria_adultos = 40.50,
                valor_diaria_criancas = 20.25
            },

            new Model.dados()
            {
                descricao = "Suíte Luxo",
                valor_diaria_adultos = 20.50,
                valor_diaria_criancas = 15
            },

            new Model.dados(){ 
                descricao = "Suíte Pobre",
                valor_diaria_adultos = 15,
                valor_diaria_criancas = 10
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new View.cadastro_hospedagem();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
