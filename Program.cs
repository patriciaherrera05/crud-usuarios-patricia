using System;

// Cambio en feature/login-form
// Validación de entrada del usuario implementada
// Integración de API de pagos (simulación)



namespace crud_usuarios_patricia
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            int opcion;

            do
            {
                Console.WriteLine("\n=== CRUD de Usuarios ===");
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Listar usuarios");
                Console.WriteLine("3. Actualizar usuario");
                Console.WriteLine("4. Eliminar usuario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠ Entrada inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        repo.CrearUsuario(nombre, correo);
                        break;

                    case 2:
                        repo.ListarUsuarios();
                        break;

                    case 3:
                        Console.Write("ID del usuario a actualizar: ");
                        int idActualizar = int.Parse(Console.ReadLine());
                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();
                        Console.Write("Nuevo correo: ");
                        string nuevoCorreo = Console.ReadLine();
                        repo.ActualizarUsuario(idActualizar, nuevoNombre, nuevoCorreo);
                        break;

                    case 4:
                        Console.Write("ID del usuario a eliminar: ");
                        int idEliminar = int.Parse(Console.ReadLine());
                        repo.EliminarUsuario(idEliminar);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("⚠ Opción no válida.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}

