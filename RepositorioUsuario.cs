using System;
using System.Collections.Generic;
using System.Linq;

namespace crud_usuarios_patricia
{
    public class RepositorioUsuario
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private int proximoId = 1;

        public void CrearUsuario(string nombre, string correo)
        {
            Usuario nuevo = new Usuario
            {
                Id = proximoId++,
                Nombre = nombre,
                Correo = correo
            };
            usuarios.Add(nuevo);
            Console.WriteLine("✔ Usuario creado correctamente.");
        }

        public void ListarUsuarios()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("⚠ No hay usuarios registrados.");
                return;
            }

            Console.WriteLine("\n--- Lista de Usuarios ---");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.Id} | Nombre: {u.Nombre} | Correo: {u.Correo}");
            }
        }

        public void ActualizarUsuario(int id, string nuevoNombre, string nuevoCorreo)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre;
                usuario.Correo = nuevoCorreo;
                Console.WriteLine("✔ Usuario actualizado.");
            }
            else
            {
                Console.WriteLine("❌ Usuario no encontrado.");
            }
        }

        public void EliminarUsuario(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
                Console.WriteLine("✔ Usuario eliminado.");
            }
            else
            {
                Console.WriteLine("❌ Usuario no encontrado.");
            }
        }
    }
}
