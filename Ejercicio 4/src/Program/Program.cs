using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] a;
            a = Archivo.LeerArchivo("C:\\Users\\Administrador\\Documents\\Programación\\Expert-SRP\\Ejercicio 4\\board.txt");
            GameBoard g = new GameBoard(a);
            ImprimirTablero.ImprimirConsola(g);
        }
    }
}
