class NodoEstudiante
{
    public int codigo;
    public string nombre;

    public ListaMaterias materias;

    public NodoEstudiante siguiente;

    public NodoEstudiante(int codigo, string nombre)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.materias = new ListaMaterias();
        this.siguiente = null;
    }
}