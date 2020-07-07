﻿using Ideas.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegisterPage();
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
