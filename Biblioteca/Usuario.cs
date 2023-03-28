using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        private string _id;
        private string _nombre;
        private List<Libro> _librosAsignados;


        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        internal List<Libro> LibrosAsignados { get => _librosAsignados; set => _librosAsignados = value; }



        public Usuario(string id,string nombre) 
        {
            _id = id;
            _nombre = nombre;
            _librosAsignados = new List<Libro>();
        }

       
        public void AsignarLibro(Libro libro)
        {
            LibrosAsignados.Add(libro);
        }

        public void DevolverLibro(Libro libro)
        {
            LibrosAsignados.Remove(libro);
        }
    }
}
