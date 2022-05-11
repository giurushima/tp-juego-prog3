using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre = "";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public int x;
        
        public virtual int CalcularDanio(int Agilidad, int Fuerza, int Magia)
        {
            return x;
        }
      
        public virtual string Atacar()
        {
            return $"{Nombre} hizo {x} de daño";
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
