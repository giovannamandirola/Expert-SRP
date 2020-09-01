using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
        public Boolean PuedeComprar(Double dinero, String moneda) 
        {
            Double pesos = Pesos.ConvertirAPesos(dinero, moneda);
            return pesos >= this.PrecioDulce + this.PrecioMasa;
        }
    }
}