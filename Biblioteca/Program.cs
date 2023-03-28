



using System.Data.Common;

namespace  Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {

            Biblioteca biblioteca = new Biblioteca("89765465-5", "Julieta Gomez");
            Menu menu = new Menu();
            int valor = 0;
            string nomb = "", ident = "";

            do
            {
                valor = menu.MenuPrincipal();
                switch (valor)
                {
                    case 1: AddUser(ident, nomb, biblioteca); break;
                    case 2: ListUser(biblioteca); break;
                    case 3: DeleteUser(biblioteca); break;
                    case 4: ViewUser(valor, biblioteca, menu); break;
                    case 5: AddBook(ident, nomb, biblioteca); break;
                    case 6: ListBook(biblioteca); break;
                    case 7: DeleteBook( biblioteca); break;

                }

            } while (valor != 8);

        }

        public static void AddUser(string ident, string nombre, Biblioteca biblioteca)
        {
            Console.WriteLine("Ingrese Identificacion: ");
            ident = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            biblioteca.AgregarUsuario(new Usuario(ident, nombre));
            Console.WriteLine("Usuario agregado con exito");
        }

        public static void ListUser(Biblioteca biblioteca)
        {
            Console.WriteLine("Lista de usuarios");
            foreach (Usuario usuario in biblioteca.ListarUsuario())
            {
                Console.WriteLine("Usuario: " + usuario.Nombre);
            }
        }

        public static void DeleteUser(Biblioteca biblioteca)
        {
            Console.WriteLine("Ingrese ID de usuario: ");
            biblioteca.BorrarUsuario(biblioteca.Usuarios[int.Parse(Console.ReadLine())]);
            Console.WriteLine("Se elimino el usuario con exito.");
        }

        public static void ViewUser(int valor, Biblioteca biblioteca, Menu menu)
        {
            Console.WriteLine("Ingrese el Id del usuario a visualizar: ");
            valor = int.Parse(Console.ReadLine());
            biblioteca.Usuarios[valor] = menu.MenuUsuario(biblioteca.Usuarios[valor], biblioteca.Libros);
        }

        public static void AddBook(string ident, string nomb, Biblioteca biblioteca)
        {
            Console.WriteLine("Id del libro: ");
            ident = Console.ReadLine();
            Console.WriteLine("Nombre del libro: ");
            nomb = Console.ReadLine();
            biblioteca.AgregarLibro(new Libro(int.Parse(ident), nomb));
            Console.WriteLine("Libro agregado con exito");
        }

        public static void ListBook(Biblioteca biblioteca)
        {
            Console.WriteLine("Lista de libros en la biblioteca: ");
            foreach (var libro in biblioteca.Libros)
            {
                Console.WriteLine("Libro: " + libro.Nombre);
            }
        }

        public static void DeleteBook(Biblioteca biblioteca)
        {
            Console.WriteLine("Ingrese ID del Libro: ");
            biblioteca.BorrarLibro(biblioteca.Libros[int.Parse(Console.ReadLine())]);
            Console.WriteLine("Libro eliminado con exito.");

        }
    }
}

 


