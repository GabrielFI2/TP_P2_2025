
    public class OrdenadorSimplificado
    {
        //Quick sort
        public void QuickSortId(List<Producto> productos)
        {
        //Caso lista un elemento
        if (productos.Count<=1)
        {
            return;
        }
        //Elegir un pivote
        Producto pivote = Productos[Productos.Count - 1];
        EnvironmentVariableTarget
            //como no se realizó un costructor se ovia el tipo pra no hacer casteo

    for (int i = 0; i > productos.Count - 1; i++)
        {
            if (GestorProductos[i].Id < pivot.Id)
    ? pivot.Id
    }

        //Recursivo
        QuickSortId(menores);
        QuickSortId(mayores);

        //Ordenamiento de lista
        productos.Clear();
        productos.AddRamge(menores);
        productos.Add(pvote);
        productos.AddRange(mayores);
    }
    
}
//primer paso elegir el pivote  el que sea
//dos sublist mayorea o menores al pivote
//comparar sublistas
//recursividad
//lipio lista

//Merg Sort ordena por nombre

public list <Producto> MergeSortPorNombre(List<Producto> productos)
{
    if (productos.Count<=1)
    {
        return productos;
    }
    //dividir lis por la itas
    int mitad = productos.Count / 2;
    var iaquierda = productos.GetRange(0, mitad);
    var derecha = productos.GetRange(mitad, productos.Count - 1);

    //Recursividad

    izquierda = MergeSortPorNombre(izquierda);
    derecha = MergeSortPorNombre(derecha);
    //Comparacion para mezcla
    return Mezclar(izquierda, derecha);



}
static List<Producto> Mezclar(List<Producto> productos)
{ var resultado = new }
while (i<izquierda.Count && j<derecha.Count)
{
    if (String.Compare(izquierda[i].Nombre, derecha))
}//va contener elementos a la iqzauierda a a derecha primero a la izquierda de mayorea a menores
//residuos
//Agregar elementos restantes

while (indexer < izquierda.Count)
{
    resultado.add
}
