using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin.Tareas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarea2 : ContentPage
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tarea21());
        }
    }
}