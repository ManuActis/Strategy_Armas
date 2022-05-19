using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    public class Jugador
    {   
        //Agregacion al objeto Arma
        Arma _arma;

        public void CambiarArma(Arma arma)
        {
            _arma = arma;
        }

        public void Disparar()
        {
            if (_arma == null) Console.WriteLine("Acuchillar al aire");
            _arma.Disparar();
        }
        public string Nombre { get; set; }

    }
}
