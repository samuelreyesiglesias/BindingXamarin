using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiPagina : ContentPage
    {
        public MiPagina()
        {
            InitializeComponent();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Mostrando nombre", "Tu nombre es:", "Cancelar");
        //}
    }
}