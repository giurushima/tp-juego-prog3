using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string Name, int Agility, int Magic)
        {
            Nombre = Name;
            Fuerza = 100;
            Agilidad = Agility;
            Magia = Magic;
        }
        public int CalcularDanio()
        {
            x = Fuerza * 25 + Agilidad * 15 + Magia * 30 / 2;
            return x;
        }
    }
}
