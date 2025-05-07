using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;
using System.Xml;

Console.WriteLine("===SISTEMA DE GESTION DE GIMNASIO 'PROGRAM POWER'");

//crear Usuario
Console.WriteLine("Ingresa el nombre del usuario; ");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad del usuario; ");
int edadUsuario = int.Parse(Console.ReadLine()) ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (e.g. Fuerza, Resistencia");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//crear entrenador
Console.WriteLine("Ingresa el nombre mdel entrenador; ");
string nombreEntrenador = Console.ReadLine()??"";

Console.WriteLine("Ingresa la especialidad; ");
string especialidadEntrenador = Console.ReadLine() ?? "";

//Crear Rutina
Console.WriteLine("Ingresa el nombre del rutina; ");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duracion de la rutina en minutos ");
int duracionRutina = int.Parse(Console.ReadLine()) ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina

Console.WriteLine("¿cuantos ejercicios tinene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine()) ?? "");

for (int i = 1 1 <= numEjercicios; i++)
{
    //crear ejecicio
    Console.WriteLine($"Ejercicio {i}");
    Console.WriteLine("Nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine ?? "";
    Console

    Ejercicio ejercicio = new Ejercicio()

    //asignar ejercicio a rutina
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutinas  y entrenador al usuario
AsignadorRutinas asignadorRutinas = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignadorRutinas.AsignarUsuarioAEntrenador(usuario, Entrenador);

//Mostrar resumen

Console.WriteLine();
Console.WriteLine($"Usuario: {usuario.Nombre}\n{usuario.Objetivo}");
Console.WriteLine($"Rutina asignadada: "{usuario.RutinaAsignada.Nombre)");
Console.Write("Ejercicios a ralizar");

foreach ( var e in usuario.RutnaAsingada.ObtenerEjercicio())
{
        Console.WriteLine

}
Console.WriteLine ($"Entrenador asignado: {entrenador}")