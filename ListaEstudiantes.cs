class ListaEstudiantes
{
    public NodoEstudiante cabeza;
    private int contador = 1;

    public void Agregar(string nombre)
    {
        NodoEstudiante nuevo = new NodoEstudiante(contador++, nombre);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            NodoEstudiante aux = cabeza;
            while (aux.siguiente != null)
            {
                aux = aux.siguiente;
            }
            aux.siguiente = nuevo;
        }
    }

    public void Listar()
    {
        NodoEstudiante aux = cabeza;
        while (aux != null)
        {
            Console.WriteLine(aux.codigo + " - " + aux.nombre);
            aux = aux.siguiente;
        }
    }

    public NodoEstudiante Buscar(int codigo)
    {
        NodoEstudiante aux = cabeza;
        while (aux != null)
        {
            if (aux.codigo == codigo)
                return aux;

            aux = aux.siguiente;
        }
        return null;
    }
}