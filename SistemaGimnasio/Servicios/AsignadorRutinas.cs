using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Servicios
{
    public class AsignadorRutinas
    {
        //metodos
        public void AsignarRutinaUsuario(Usuario usuario, Rutina rutina)
        {
            usuario.AsignarRutina(rutina);
        }
        public void AsignarUsuarioEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsignarUsuario(usuario);
        }
    }
}
//no hay interaccion directa con el usuar si no con el asignador de rutinas

//nosotros debemos dividir el codigo porque no es buena prectica de programacion