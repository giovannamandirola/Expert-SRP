using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca  lugar1 = new Biblioteca("A", "7");
            Biblioteca  lugar2 = new Biblioteca("B", "3");
            libro1.AlmacenarLibro(lugar1);
            libro2.AlmacenarLibro(lugar2);
        }
    }
}
