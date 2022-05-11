using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Enemigo : IMoverse
    {
        public string Nombre;
        public int Vida;
        public int Nivel;

        public Enemigo(string Name,int Life, int Level)
        {
            Nombre = Name;
            Vida = Life;
            Nivel = Level;
        }

        public string MoverseEjeX()
        {
            throw new NotImplementedException();
        }

        public string MoverseEjeY()
        {
            throw new NotImplementedException();
        }
    }
}
