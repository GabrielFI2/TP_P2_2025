using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio.Modelos
{
    public class Ejercicio
    {
        public string Nombre { get; set; }
        public int Repetciones { get; set; }
        public int Series {  get; set; }
        public  int Descanso { get; set; }

        //Constructor

        public Ejercicio (string nombre, int repetciones, int series, int descanso)
        {
            Nombre = nombre;
            Repetciones = repetciones;
            Series = series;
            Descanso = descanso;
        }
    }
}
