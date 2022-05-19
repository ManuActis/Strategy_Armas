using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    public class M4a1_s:Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("Sh sh sh sh shh");
        }
    }
}
