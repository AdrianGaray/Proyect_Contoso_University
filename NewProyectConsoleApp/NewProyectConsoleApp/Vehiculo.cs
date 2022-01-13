using System;
using System.Collections.Generic;
using System.Text;

namespace NewProyectConsoleApp
{
    class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public Vehiculo(decimal velocidadMaxima)
        {
            VelocidadMaxima = velocidadMaxima;
        }
    }
}
