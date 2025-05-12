
internal class GestorProductos
{
    //lista para mantern el orede de insecio y oredenar
    public List<Producto> ListaProductos = new List<Producto>();

    //Diccionario para busquedas rapidas

    public Dictionary<string, Producto> diccionarioProductos = new Dictionary<string, Producto>();
    //Metodos
    public List<Producto> ObtenerListaProductos()
    {
        return new List<Producto>(ListaProductos);
    }

    //Operaciones con  lista

    public void AgregarProducto(Producto p)
    {
        //validar codigo de barras
        if (diccionarioProductos.ContainsKey(p.CodigoBarras))
        {
            throw new Exception("El codigo de barras ya existe");
        }
        //Añadir producto a Lista
        ListaProductos.Add(p);
        //Añadir codigo de barras a diccionario
        diccionarioProductos[p.CodigoBarras] = p;

    }
    public bool EliminaProducto(string codigoBarras)
    //Busco el dicionario para qe la lista lo remueva
    {
        if (diccionarioProductos.TryGetValue(codigoBarras, out var producto))
        {
            ListaProductos.Remove(producto);
            diccionarioProductos.Remove(codigoBarras);

            return true;

        }
        return false;
    }

    public void MostrarInventario()
    {
        Console.WriteLine("Inventario completo:");
        foreach (var p in ListaProductos)
        {
            Console.WriteLine(p);
        }
    }
    //Operaciones con diccionario
    public Producto BuscarPorCodigo(string codigoBarras)
    {
        return diccionarioProductos.TryGetValue(codigoBarras, out var producto) ? producto : null;
    }
    public void MostrarProductoPorCategoria(string categoria)
    {
        Console.WriteLine($"Productos en categoria: {categoria} -");
        foreach (var p in ListaProductos)
        {
            if (p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(p);
            }
        }
    }

    public bool ExisteProducto(string codigoBarras)
    {
        return diccionarioProductos.ContainsKey(codigoBarras); 
    }
}
