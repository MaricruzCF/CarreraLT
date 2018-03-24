using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLT
{
    class Tortuga:Corredor
    {
        public override void Avanzar()
        {
            int paso = rnd.Next(10);
            if (paso < 5)
            {
                _pasos += 3;
            }
            else if (paso < 7)
            {
                _pasos -= 6;
            }
            else
            {
                _pasos += 1;
            }
        }
        public override string ToString()
        {
            return "Tortuga" + base.ToString();
        }
    }
}
