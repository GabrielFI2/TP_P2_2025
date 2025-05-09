using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio.Modelos
{
    public class Entrenador
    {
        //Propiedades
        public string Nombre {  get; set; }
        public string Especialidad { get; set; }

        //Variable de la clase
        private List<Usuario> usuarioAsignados;

        //Constructor
        public Entrenador(string nombre, string especialidad )
        {
            Nombre = nombre;

            Especialidad = especialidad;
            usuarioAsignados = new List<Usuario>();
        }

        //Metodos

        public void AsignarUsuario(Usuario usuario)
        {
            usuarioAsignados.Add(usuario);
        }

    }
}
