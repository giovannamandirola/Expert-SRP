using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        //Puede comprar podría citar una función en la clase de alfajor que calcule el precio de ese alfajor y devuelva el precio
        //Por expert el experto en la información sería la clase alfajor y no el kiosco
        //El kiosco podría utilizar cada alfajor con su precio calculado
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}