using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public Biblioteca Almacenado {get; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
            this.Almacenado = Almacenado;
        }
        public void AlmacenarLibro (Biblioteca biblioteca)
        {
            this.Almacenado = biblioteca;
        }
        
    }
}
