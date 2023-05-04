using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6
{
    internal class ClasePersona
    {
        private string rut;
        private string nombre;
        private int numero;

        public ClasePersona(string rut, string nombre, int numero)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.numero = numero;
        }

        public ClasePersona()
        {
            this.rut = "defecto";
            this.nombre = "defecto";
            this.numero = 0;
        }

        public string getRut() { return this.rut; }
        public void setRut(string rut) { this.rut = rut; }

        public string getNombre() { return this.nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public int getNumero() { return this.numero; }
        public void setNumero(int numero) { this.numero = numero; }

        public void sumaNumero(int numero)
        {
            this.numero = this.numero + numero;
        }
    }
}
