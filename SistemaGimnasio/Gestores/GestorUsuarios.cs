using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    internal class GestorUsuarios
    {
        //Variable de clase
        private List<Usuario> usuarios;

        //Constructor
        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }
        //Metodos
        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            usuarios.Add(new Usuario (nombre, edad, objetivo));
        }
        
        public Usuario BuscarUsuario(String nombre)
        {
            //encuentra el primer valor qe encuentre, e ultimo que se registro
            return usuarios.FirstOrDefault(u => u.Nombre == nombre);
            //u de usuario
            //en caso de que no lo encuentre regresa nulo
        }
    }
}
     //el gestor mueve todo los usuarios instanciar usuarios