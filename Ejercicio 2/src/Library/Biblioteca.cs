using System;

namespace SRP
{
    public class Biblioteca
    {
        public string Sector { get ; }
        public string Estante { get ; }

        public Biblioteca (String sector, String estante)
        {
            this.Sector = sector;
            this.Estante = estante;
        }

    }
}