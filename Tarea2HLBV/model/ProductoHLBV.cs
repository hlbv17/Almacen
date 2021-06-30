using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2HLBV.model
{
    class ProductoHLBV
    {
        private string nombre;
        private double precioU;
        private int stock;
        private DateTime fecha;
        private int codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioU { get => precioU; set => precioU = value; }
        public int Stock { get => stock; set => stock = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public ProductoHLBV()
        {
            this.nombre = "";
            this.precioU = 0.0;
            this.stock = 0;
            this.fecha = DateTime.Now;
            this.codigo = 0;
        }

        public ProductoHLBV(string nombre, double precioU, int stock, DateTime fecha, int codigo)
        {
            this.nombre = nombre;
            this.precioU = precioU;
            this.stock = stock;
            this.fecha = fecha;
            this.codigo = codigo;
        }

        public override string ToString()
        {
            return "\r\nNombre: "+nombre+ "\r\nPrecio unitario: " + precioU+ "\r\nStock: " + stock+
                "\r\nFecha: " + fecha+ "\r\nCódigo: " + codigo;
        }

        public virtual double Comprar(int cantidad)
        {
            return precioU * cantidad;
        }

        public virtual double Vender(int cantidad)
        {
            return precioU * cantidad;
        }
    }
}
