class Program
{
    static void Main()
    {
        ListaEstudiantes lista = new ListaEstudiantes();
        int opcion;

        do
        {
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Listar estudiantes");
            Console.WriteLine("3. Agregar materia");
            Console.WriteLine("4. Salir");

            opcion = int.Parse(Console.ReadLine());

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
                    Console.Write("Codigo: ");
                    int cod = int.Parse(Console.ReadLine());

                    var est = lista.Buscar(cod);

                    if (est != null)
                    {
                        Console.Write("Materia: ");
                        string mat = Console.ReadLine();

                        Console.Write("Nota: ");
                        double nota = double.Parse(Console.ReadLine());

                        est.materias.Agregar(mat, nota);
                    }
                    else
                    {
                        Console.WriteLine("No existe");
                    }
                    break;
            }

        } while (opcion != 4);
    }
}