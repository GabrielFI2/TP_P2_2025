

namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        
        //Propiedades(Se requiere al instanciaar el objeto Rutina)
        public string Nombre { get; set; }
        public int Duracion { get; set; }

        //Variable de clase (se construye en el flujo del programa)
        //alimentadno el objeto mas de n objo y cuando se instancie, es una variable de clase
       // private List<Ejercicio> ejercicios;

        public Rutina (string Nombre, int Duracion)
        {
            Nombre = Nombre;
            Duracion = Duracion;
        }

       /* public void AgregarEjercicio(Ejercicio  ejercicio)
        {
            ejercicios.Add(ejercicio);
        }*/

        /*
        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }*/

        public void  BorrarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Remove(ejercicio);
        }
    }
}
//pruebas unitarias