using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Armas
{
    public abstract class Arma
    {

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public abstract void Disparar();


    }
}
