using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string Name, int Agility, int Magic, int Strength) {
            Nombre = Name;
            Agilidad = Agility;
            Magia = Magic;
            Fuerza = Strength;
        }
        public PersonajeDeMagia(string Name, int Agility, int Strength) {
            Nombre = Name;
            Agilidad = Agility;
            Magia = 60;
            Fuerza = Strength;
        }
        public int CalcularDanio() {
            x = Fuerza + Agilidad + Magia * 4;
            return x;
        }
        public override string Atacar() {
            return $"{Nombre} hizo {x} de daño gracias a su magia";
        }
        public new string MoverseEjeX()
        {
            throw new NotImplementedException();
        }

        public new string MoverseEjeY()
        {
            throw new NotImplementedException();
        }
    }
}

/*Crear una clase llamada PersonajeDeMagia que tenga 2 constructores,
uno que reciba los 4 atributos como parámetro y otro que reciba 3 y le ponga el atributo magia en 60 por defecto. 
Al atacar debe sobreescribir el método Atacar() para que diga: “{ nombre} hizo {x}
de daño gracias a su magia” y utilizar la fórmula Fuerza+Agilidad+Magia*4 para calcular el daño.*/