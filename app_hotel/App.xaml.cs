﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_hotel
{
    public partial class App : Application
    {
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
