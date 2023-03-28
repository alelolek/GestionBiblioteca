using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Menu
    {
        public int MenuPrincipal()
        {
            Console.WriteLine("Biblioteca Universidad");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Agregar usuario");
            Console.WriteLine("2. Listar usuario");
            Console.WriteLine("3. Borrar usuario");
            Console.WriteLine("4. Ver usuario");
            Console.WriteLine("5. Agregar Libro a la Biblioteca");
            Console.WriteLine("6. Listar Libros de la Biblioteca");
            Console.WriteLine("7. Borrar Libro");
            Console.WriteLine("8. Salir");
            Console.WriteLine("ingresa una opcion: ");
            return int.Parse(Console.ReadLine());
        }


        public Usuario MenuUsuario(Usuario usuario, List<Libro> libros)
        {
            int valor = 0;

            do
            {

                Console.WriteLine("Usuario " + usuario.Nombre);
                Console.WriteLine("1. Prestar libro");
                Console.WriteLine("2. Devolver libro");
                Console.WriteLine("3. Ver libros prestados al usuario");
                Console.WriteLine("4. Regresar");

                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        Console.WriteLine("ingrese el Id del libro a prestar: ");
                        usuario.AsignarLibro(libros[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Libro Asignado con exito");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el Id del libro: ");
                        usuario.DevolverLibro(usuario.LibrosAsignados[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Libro devuelto con exito"); break;
                    case 3:
                        Console.WriteLine("Lista de libros prestados");
                        foreach (var libro in usuario.LibrosAsignados)
                        {
                            Console.WriteLine("Libro: " + libro.Nombre);
                        }
                        break;
                    default:
                        break;
                }
            } while (valor != 4);
            return usuario;
            

        }
    }
}
