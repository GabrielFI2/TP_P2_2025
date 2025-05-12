/*//Recorr
//por el 34
foreach (KeyValuePair <string,int> parDiccionario in 
    //Diccionario
    ////es mas facil buscar por clave o or nombre retornar todo lo que conllev el nombre) esto no es parte de la practica
    ///Practica 3
    ///*/

//Actividad 1 lista y diccionario, necesitamos un objeto objeto que se van a guardar
//tres operaciones fundamentasles agreagar

public class Producto
{
    //Propiedades
    public int Id { get; set; }
    public string CodigoBarras { get; set; }

    public string Nombre { get; set; } 
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public override string ToString()
    {
        return $"[{Id}]- {CodigoBarras} - {Nombre}|"
    }

}