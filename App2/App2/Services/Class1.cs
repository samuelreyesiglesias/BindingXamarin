using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using App2.Views;

namespace App2.Services
{
    public class Class1
    {
        public string Name { get; set; } = "Samuel";
        public string Surname { get; set; } = "Reyes";
 

        public Command Comando { get; set; } = null;
        public Command Ir { get; set; } = null;
        public Class1()
        {
            Comando = new Command(MiMetodo);
             Ir = new Command(ir);
        }

        public   void MiMetodo()
        {

            App.Current.MainPage.DisplayAlert("Hola", "Como estas?" + this.Name + this.Surname, "OK");

        }

        public void ir()
        {

            //App.Current.MainPage.DisplayAlert("Hola", "Como estas?" + this.Name + this.Surname, "OK");
            MiPagina2 Pagina = new MiPagina2();
            App.Current.MainPage = Pagina;


        }


    }
}
