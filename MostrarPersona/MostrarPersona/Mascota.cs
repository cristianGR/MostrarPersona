using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MostrarPersona
{
    class Mascota : INotifyPropertyChanged
    {
        private string tipo;
        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
                OnPropertyChanged();
            }
        }
        private string nombre;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
