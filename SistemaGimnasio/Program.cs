using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;
using System.Xml;

Console.WriteLine("===SISTEMA DE GESTION DE GIMNASIO 'PROGRAM POWER'");

//crear Usuario
Console.WriteLine("Ingresa el nombre del usuario; ");
string nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad del usuario; ");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (e.g. Fuerza, Resistencia");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);


//crear entrenador
Console.WriteLine("Ingresa el nombre mdel entrenador; ");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad; ");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);


//Crear Rutina
Console.WriteLine("Ingresa el nombre del rutina; ");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duracion de la rutina en minutos ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);


//Agregar ejercicios a la rutina

Console.WriteLine("¿cuantos ejercicios tinene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i++)
{
    //crear ejecicio
    Console.WriteLine($"Ejercicio {i}");
    Console.WriteLine("Nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Numero de repeticiones ejercicio");
    int repticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Numero de series de ejercicios");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso en minutos");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repticiones, series, descanso);

    //asignar ejercicio a rutina
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutinas  y entrenador al usuario
AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaUsuario(usuario, rutina);
asignador.AsignarUsuarioEntrenador(usuario, entrenador);

//Mostrar resumen

Console.WriteLine("===REsuimen");
Console.WriteLine($"Usuario: {usuario.Nombre}\n{usuario.Objetivo}");
Console.WriteLine($"Rutina asignadada: {usuario.RutinaAsignada.Nombre} ");
Console.Write("Ejercicios a ralizar");

foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre} | Series {e.Series} | Repeticiones {e.Repetciones} |Descanso {e.Descanso}");

}
Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} especialidad {entrenador.Especialidad}");