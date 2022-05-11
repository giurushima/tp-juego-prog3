using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal interface IMoverse
    {
        string MoverseEjeX();
        string MoverseEjeY();
    }
}

/*Crear una interfaz IMoverse que tenga 2 métodos: MoverseEjeX y MoverseEjeY. Todos los personajes y enemigos deben implementar esta interfaz.*/
