using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador jugador = new Jugador();
            jugador.Nombre = "MatoATodos98";

            Console.WriteLine("[Empezas la ronda con pistola porque no tenes plata]");
            Arma arma = new Glock();
            jugador.CambiarArma(arma);

            Console.WriteLine("[Te escondes y le disparas al primer enemigo que aparece...]");
            jugador.Disparar();

            Console.WriteLine("[Lo mataste. Ahora le robas su Ak47]");
            arma = new Ak47();
            jugador.CambiarArma(arma);

            Console.WriteLine("[Estas uno vs uno y si ganas tus amigos te van a decir que ya no sos peor que Tomi]");
            Console.WriteLine("[Ves al rival y disparas todo el cargador casi sin apuntar...]");
            jugador.Disparar();

            Console.WriteLine("[Mataste al último enemigo de la ronda errandole casi todos los tiros!!]");
            Console.WriteLine("[Decidis no volver a usar una AK47 nunca y agarras su M4A1-S para la proxima ronda]");

            arma = new M4a1_s();
            jugador.CambiarArma(arma);
            
            Console.WriteLine("[Disparas al cielo para festejar que ganaron la ronda y ahora perdiendo solo por once rondas]");
            jugador.Disparar();

            Console.ReadKey();

        }
    }
}
