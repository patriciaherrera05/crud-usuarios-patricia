using System;

// Proyecto CRUD Usuarios - Programación III
// Autor: Patricia Herrera
// Funcionalidades:
// - feature/login-form: implementación del formulario de inicio de sesión (validación de entrada incluida)
// - feature/payment-api-integration: integración simulada de API de pagos
// - feature/user-dashboard: desarrollo del panel de usuario (dashboard)

namespace crud_usuarios_patricia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del repositorio para manejar usuarios
            RepositorioUsuario repo = new RepositorioUsuario();
            int opcion;

            do
            {
                // Mostrar menú principal del CRUD
                Console.WriteLine("\n=== CRUD de Usuarios ===");
                // feature/login-form
                // Aquí podría integrarse la lógica del formulario de inicio de sesión

                // feature/user-dashboard
                // Aquí se mostraría el panel de usuario (dashboard) después de login exitoso
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Listar usuarios");
                Console.WriteLine("3. Actualizar usuario");
                Console.WriteLine("4. Eliminar usuario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                // Validar que la entrada sea un número entero válido
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠ Entrada inválida. Intente de nuevo.");
                    continue;
                }
                // Procesar la opción seleccionada por el usuario
                switch (opcion)
                {
                    case 1:
                        // Solicitar datos para crear un nuevo usuario
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        // feature/payment-api-integration
                        // Aquí se podría simular una llamada a API de pagos al crear un usuario
                        repo.CrearUsuario(nombre, correo);
                        break;

                    case 2:
                        // Mostrar la lista de usuarios existentes
                        repo.ListarUsuarios();
                        break;

                    case 3:
                        // Solicitar datos para actualizar un usuario existente
                        Console.Write("ID del usuario a actualizar: ");
                        int idActualizar = int.Parse(Console.ReadLine());
                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();
                        Console.Write("Nuevo correo: ");
                        string nuevoCorreo = Console.ReadLine();
                        repo.ActualizarUsuario(idActualizar, nuevoNombre, nuevoCorreo);
                        break;

                    case 4:
                        // Solicitar el ID del usuario a eliminar
                        Console.Write("ID del usuario a eliminar: ");
                        int idEliminar = int.Parse(Console.ReadLine());
                        repo.EliminarUsuario(idEliminar);
                        break;

                    case 5:
                        // Opción para salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        // Manejar opciones no válidas
                        Console.WriteLine("⚠ Opción no válida.");
                        break;
                }

            } while (opcion != 5); // Repetir hasta que el usuario elija salir
        }
    }
}

