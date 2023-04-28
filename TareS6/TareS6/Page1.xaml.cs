using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { Nombres = "Eduardo", Apellidos = "Villanueva", Edad = 20 });
            personas.Add(new Persona { Nombres = "Jose", Apellidos = "Diaz", Edad = 22 });
            personas.Add(new Persona { Nombres = "Percy", Apellidos = "Herrera", Edad = 20 });
            personas.Add(new Persona { Nombres = "Johan", Apellidos = "Mestas", Edad = 21 });
            lvDemo.ItemsSource=personas;
        }
    }
}