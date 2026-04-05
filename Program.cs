using System;

class Program
{
    static void Main()
    {
        ListaEstudiantes lista = new ListaEstudiantes();
        int opcion = 0;

        do
        {
            Console.WriteLine("\n--- SISTEMA DE ESTUDIANTES ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Listar estudiantes");
            Console.WriteLine("3. Agregar materia");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) continue;

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    lista.Agregar(nombre);
                    break;

                case 2:
                    lista.Listar();
                    break;

                case 3:
                    Console.Write("Codigo del estudiante: ");
                    if (int.TryParse(Console.ReadLine(), out int cod))
                    {
                        var est = lista.Buscar(cod);
                        if (est != null)
                        {
                            Console.Write("Materia: ");
                            string mat = Console.ReadLine();
                            Console.Write("Nota: ");
                            if (double.TryParse(Console.ReadLine(), out double nota))
                            {
                                est.materias.Agregar(mat, nota);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe el estudiante.");
                        }
                    }
                    break;
            }
        } while (opcion != 4);
    }
}

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
        if (aux == null) { Console.WriteLine("Lista vacía."); return; }
        while (aux != null)
        {
            Console.WriteLine($"ID: {aux.codigo} - Nombre: {aux.nombre}");
            aux.materias.Listar(); 
            aux = aux.siguiente;
        }
    }

    public NodoEstudiante Buscar(int codigo)
    {
        NodoEstudiante aux = cabeza;
        while (aux != null)
        {
            if (aux.codigo == codigo) return aux;
            aux = aux.siguiente;
        }
        return null;
    }
}

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
            Console.WriteLine($"   > Materia: {aux.nombre} - Nota: {aux.nota}");
            aux = aux.siguiente;
        }
    }
}

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

class NodoMateria
{
    public string nombre;
    public double nota;
    public NodoMateria siguiente;

    public NodoMateria(string nombre, double nota)
    {
        this.nombre = nombre;
        this.nota = nota;
        this.siguiente = null;
    }
}