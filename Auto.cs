using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Auto : ICloneable
    {
        private string? patente;
        private string? Marca;
        private string? Modelo;
        private string? Año;
        private double Precio;

        public Auto( string p , string m , string mo ,string a, string pr )
        {
            patente = p;
            Marca = m;
            Modelo = mo;
            Año = a;
            Precio = Convert.ToDouble(pr);
        }
        public Auto()
        {
            patente = null;
            Marca = null;
            Modelo = null;
            Año = null;
            Precio = double.NaN;
        }
        public Auto( Auto newA )
        {
            this.Año = newA.Año;
            this.Marca = newA.Marca;
            this.Modelo = newA.Modelo;
            this.patente = newA._patente;
            this.Precio = newA.Precio;
        }
        public string _patente
        {
            get { return patente; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("[ERROR] Patente nulo");  
                patente = value;
            }
        }
        public string _marca
        {
            get { return Marca; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("[ERROR] Marca nulo");
                Marca = value;
            }
        }
        public string _modelo
        {
            get { return Modelo; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("[ERROR] Marca nulo");
                Modelo = value;
            }
        }
        public string _año
        {
            get { return Año; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("[ERROR] Año nulo");
                Año = value;
            }
        }
        public double _precio
        {
            get { return Precio;}
            set
            {
                if (this.Precio < 0) throw new ArgumentException("[ERROR] Precio No puede ser negativo");
                Precio = value;
            }
        }

        public object Clone()
        {
            return (Auto)this.MemberwiseClone();
        }
    }

}
