using System;

namespace Clase1
{
    public class Carro : Vehiculo
    {
        public int Cilindraje { get; set; }        
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Motor { get; set; }
        public string Placa { get; set; }
        public Llanta Llantas { get; set; }

        private int Frenar(int fuerza) {
            //
            return 0;
        }
    }
}
