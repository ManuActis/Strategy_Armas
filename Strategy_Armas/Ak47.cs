using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    public class Ak47:Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("Taka taka taka taka taka");
        }
    }
}
