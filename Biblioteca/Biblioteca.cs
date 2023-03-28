using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca : Universidad
    {
        private string _nombre;
        private List<Usuario> _usuarios;
        private List<Libro> _libros;

        public string Nombre { get => _nombre; set => _nombre = value; }
        internal List<Usuario> Usuarios { get => _usuarios; set => _usuarios = value; }
        internal List<Libro> Libros { get => _libros; set => _libros = value; }

        public Biblioteca(string id,string nombre)
        {
            _nombre = nombre;
            this.Id = id; //Id de universidad
            _usuarios = new List<Usuario>();
            _libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            _libros.Add(libro);
        }

        public void BorrarLibro(Libro libro)
        {
            _libros.Remove(libro);
        }

        public List<Usuario> ListarUsuario()
        {
            return _usuarios; 
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void BorrarUsuario(Usuario usuario)
        {
            _usuarios.Remove(usuario);
        }
    }
}
