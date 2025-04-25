using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Persona : ICloneable
    {
        private string nombre;
        private string apellido;
        private string dni;

        public Persona(string n, string a, string d)
        {
            nombre = n;
            apellido = a;
            dni = d;
        }
        public Persona()
        {
            nombre = null;
            apellido = null;
            dni = null;
        }

        public Persona( Persona newP )
        {
            this.dni = newP.dni;
            this.apellido = newP.apellido;  
            this.nombre = newP.nombre;
        }
        public string _dni
        {
            get { return dni; }
            set
            {
                if (string.IsNullOrEmpty(dni)) throw new ArgumentNullException();
                dni = value;
            }
        }
        public string _nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(nombre)) throw new ArgumentNullException();
                nombre = value;
            }
        }
        public string _apellido
        {
            get { return apellido; }
            set
            {
                if ( string.IsNullOrEmpty(apellido)) throw new ArgumentNullException();
                apellido = value;
            }
        }

        public object Clone()
        {
            return (Persona)this.MemberwiseClone();
        }
    }
}
