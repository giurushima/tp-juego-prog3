using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string Name, int Agility, int Magic, int Strength)
        {
            Nombre = Name;
            Agilidad = Agility;
            Magia = Magic;
            Fuerza = Strength;
          
        }
        public int CalcularDanio() {
            x = Fuerza / 2 * Agilidad * Magia / 2;
            return x;
        }
    }
}

/*Crear una clase llamada PersonajeDeAgilidad que tenga un constructor que reciba los 4 atributos como parámetro. 
Al atacar debe implementar el método CalcularDanio() y utilizar la fórmula Fuerza/2*Agilidad*Magia/2 para calcular el daño.*/