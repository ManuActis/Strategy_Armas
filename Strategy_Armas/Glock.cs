using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    public class Glock:Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("pium pium pium pium");
        }
    }
}
