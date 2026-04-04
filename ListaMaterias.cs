class ListaMaterias
{
    public NodoMateria cabeza;

    public void Agregar(string nombre, double nota)
    {
        NodoMateria nuevo = new NodoMateria(nombre, nota);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            NodoMateria aux = cabeza;
            while (aux.siguiente != null)
            {
                aux = aux.siguiente;
            }
            aux.siguiente = nuevo;
        }
    }

    public void Listar()
    {
        NodoMateria aux = cabeza;
        while (aux != null)
        {
            Console.WriteLine(aux.nombre + " - " + aux.nota);
            aux = aux.siguiente;
        }
    }
}