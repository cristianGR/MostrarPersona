using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MostrarPersona
{
    class Persona : INotifyPropertyChanged 
    {
        private string nombre;
        private string país;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }

        }

        public string País
        {
            get
            {
                return país;
            }
            set
            {
                país = value;
                OnPropertyChanged();
            }
        }

        public Mascota Mascota { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
