using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorRutinas
    {
        //variable de clse
        private List<Rutina> rutinas;

        //constructor
        public GestorRutinas()
        {
            rutinas = new List<Rutina>();
        }

        //Metodos

        public void CrearRutina(string nombre, int duracion)
        {
            rutinas.Add(new Rutina(nombre, duracion));
        }
        public Rutina BuscarRutina(string nombre)
        {
            return rutinas.FirstOrDefault(r => r.Nombre == nombre);
            //r de rutina
        }
    }
}
