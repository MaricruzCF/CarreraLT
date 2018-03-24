using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLT
{
    class Liebre:Corredor
    {
        public override void Avanzar()
        {
            int paso = rnd.Next(10);
            if (paso < 2)
            {
                _pasos = 0;
            }
            else if (paso < 4)
            {
                _pasos += 9;
            }
            else if (paso < 5)
            {
                _pasos -= 12;
            }
            else if (paso < 8)
            {
                _pasos += 1;
            }
            else
            {
                _pasos -= 2;
            }
        }
        public override string ToString()
        {
            return "Liebre"+base.ToString();
        }
    }
}
