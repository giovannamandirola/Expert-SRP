using System;

namespace SRP
{
    public class Libro
    {
        /* Se podría generar una nueva clase bibiloteca, donde estén los datos del sector y estante donde se almacena el libro teniendo 
        que por expert Almacenar libro se encuentre en la clase Bibloteca.
        Las clases definidas de esta manera tendrían por lo menos dos razones de cambio, ejemplo por cambio de lugar físico donde se
        almacenan,tambien se podría ver modificada por cambios en el codigo del libro. Hacer ese cambio haría el código más ordenado
        ante eventuales cambios. Agregar más datos sobre el libro*/

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
