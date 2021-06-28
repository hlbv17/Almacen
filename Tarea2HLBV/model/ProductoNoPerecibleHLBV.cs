using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2HLBV.model
{
    class ProductoNoPerecibleHLBV : ProductoHLBV
    {
        private DateTime fechaE;
        private DateTime fechaV;

        public DateTime FechaE { get => fechaE; set => fechaE = value; }
        public DateTime FechaV { get => fechaV; set => fechaV = value; }

        public ProductoNoPerecibleHLBV(DateTime fechaE, DateTime fechaV, string nombre,
            double precioU, int stock, DateTime fecha, int codigo) : base(nombre, 
                precioU, stock, fecha, codigo)
        {
            this.fechaE = fechaE;
            this.fechaV = fechaV;
        }

        public override string ToString()
        {
            return base.ToString()+ "\r\nFecha de emisión: " + fechaE+ 
                "\r\nFecha de vencimiento: " + fechaV;
        }

        public override double Comprar(int cantidad)
        {
            return base.Comprar(cantidad);  
        }

        public override double Vender(int cantidad)
        {
            return base.Vender(cantidad);
        }

        public string TiempoCaducidad(DateTime fechaE, DateTime fechaV)
        {
            TimeSpan diferencia = fechaV - fechaE;
            int dias = diferencia.Days;
            return "\nCaduce en: "+dias.ToString();
        }
    }
}
