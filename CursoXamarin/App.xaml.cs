﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tareas.Tarea21();
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
