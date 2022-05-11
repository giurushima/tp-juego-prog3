namespace Juego
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("PERSONAJES");

            List <Personaje> personajes = new List<Personaje>();
            personajes.Add(new PersonajeDeFuerza("Gabriel", 50, 40));
            personajes.Add(new PersonajeDeAgilidad("Nicolas", 50, 40, 50));
            personajes.Add(new PersonajeDeMagia("Pablo", 20, 30));

            foreach (var personaje in personajes) {
                Console.WriteLine($"Nombre: {personaje.Nombre} Fuerza: {personaje.Fuerza} Magia: {personaje.Magia} Agilidad: {personaje.Agilidad}");
            }

            Console.WriteLine("----");

            Console.WriteLine("ENEMIGOS");

            List<Enemigo> enemigos = new List<Enemigo>();
            enemigos.Add(new Enemigo("Esteban", 95, 25));
            enemigos.Add(new Enemigo("Facundo", 75, 20));
            enemigos.Add(new Enemigo("Carlos", 85, 15));

            foreach (var enemigo in enemigos)
            {
                Console.WriteLine($"Nombre: {enemigo.Nombre} Vida: {enemigo.Vida} Nivel: {enemigo.Nivel}");
            }
        }
    }
}