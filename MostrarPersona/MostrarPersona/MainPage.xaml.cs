using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MostrarPersona
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Persona persona;
        public MainPage()
        {
            InitializeComponent();
            CrearPersona();
            EnlazarDatos();
        }

        private void CrearPersona()
        {
            persona = new Persona(){
                Nombre = "Carlos",
                País = "Argentina",
                Mascota = new Mascota(){
                    Tipo = "perro",
                    Nombre = "Terry"
                }
            };
        }

        public void EnlazarDatos()
        {
            PanelPersona.BindingContext = persona;
            PanelMascota.BindingContext = persona.Mascota;
        }

        public void CambiarPersona(object sender, EventArgs args)
        {
            persona.Nombre = "Rodrigo";
            persona.País = "Argentina";
            persona.Mascota.Tipo = "gato";
            persona.Mascota.Nombre = "Michi";
        }
    }
}