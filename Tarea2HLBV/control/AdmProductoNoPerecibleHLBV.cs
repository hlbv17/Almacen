using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea2HLBV.model;

namespace Tarea2HLBV.control
{
    class AdmProductoNoPerecibleHLBV
    {
        List<ProductoHLBV> lista = new List<ProductoHLBV>();
        ValidacionHLBV v = new ValidacionHLBV();
        ProductoHLBV p = null;
        //ProductoNoPerecibleHLBV pnp = null;


        internal ProductoNoPerecibleHLBV MasCaro()
        {
            return (ProductoNoPerecibleHLBV)lista.Max();
        }


        internal List<ProductoHLBV> OrdenarXCaducacion()
        {
            List <ProductoHLBV> ordenado = lista.OrderBy(x => x.Fecha).ToList();
            //Console.WriteLine(String.Join(Environment.NewLine, ordenado));
            return ordenado;
        }

        internal bool EsCorrecto(string nombre, string precioU, DateTime fecha,
            string codigo, DateTime fechaE, DateTime fechaV, string cantidad)
        {
            bool x = true;
            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(precioU) && String.IsNullOrEmpty(cantidad)
                && String.IsNullOrEmpty(codigo) && fechaE != null && fechaE != null && v.EsEntero(cantidad)
                && v.EsEntero(codigo) && v.EsReal(precioU))
            {
                x = true;
            }
            return x;
        }

        internal void Limpiar(TextBox txtNombre, TextBox txtPrecioU, TextBox txtCantidad, 
            TextBox txtCodigo)
        {
            txtNombre.Text = "";
            txtPrecioU.Text = "";
            txtCantidad.Text = "";
            txtCodigo.Text = "";

        }

        internal bool ProductoExiste(string nombre)
        {
            bool flag = true;
            try
            {
                flag = lista.Any(x => x.Nombre == nombre);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: El producto no existe");
                flag = false;
            }
            return flag;
        }

        internal int IndexProductoExiste(string nombre)
        {
            int n = 0;
            try
            {
                n = lista.FindIndex(x => x.Nombre == nombre);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: El producto no existe en stock");
            }
            return n;
        }

        internal int Compra(int iCantidad, int indice)
        {
            int stock = lista[indice].Stock;
            stock += iCantidad;
            return stock;
        }

        internal int Vende(int iCantidad, int indice)
        {
            int stock = lista[indice].Stock;
            stock -= iCantidad;
            return stock;
        }

        internal void guardar(string nombre, string precioU, DateTime fecha,
            string codigo, DateTime fechaE, DateTime fechaV, string cantidad, string accion)
        {
            ProductoNoPerecibleHLBV pnp = null;
            double dPrecioU = v.AReal(precioU);
            int iCantidad = v.AEntero(cantidad);
            int iCodigo = v.AEntero(codigo);
            int stock = 0, indice = 0;
            if(accion.Equals("Compra"))
            {
                if (ProductoExiste(nombre))
                {
                    indice = IndexProductoExiste(nombre);
                    stock = Compra(iCantidad, indice);
                    pnp = new ProductoNoPerecibleHLBV(fechaE, fechaV, nombre, dPrecioU, stock, fecha, iCodigo);
                    lista.Add(pnp);
                }
                else
                {
                    stock = iCantidad;
                    pnp = new ProductoNoPerecibleHLBV(fechaE, fechaV, nombre, dPrecioU, stock, fecha, iCodigo);
                    lista.Add(pnp);
                    
                }
            }
            else if(accion.Equals("Venta"))
            {
                if (ProductoExiste(nombre))
                {
                    indice = IndexProductoExiste(nombre);
                    stock = Vende(iCantidad, indice);
                    pnp = new ProductoNoPerecibleHLBV(fechaE, fechaV, nombre, dPrecioU, stock, fecha, iCodigo);
                    lista.Add(pnp);
                }
                else
                {
                    MessageBox.Show("Error: No existe ese producto");
                }
            }
        }

        internal void agregar(TextBox txtContenido)
        {
            txtContenido.Text += "\r\n" +lista[lista.Count - 1].ToString();
        }


        internal void Buscar(string nombre, TextBox txtPrecioU, TextBox txtCodigo, 
            DateTime dtpFechaE, DateTime dtpFechaV)
        {
            string valores;
            int indice = 0;
            if (ProductoExiste(nombre))
            {
                indice = IndexProductoExiste(nombre);
                txtPrecioU.Text = lista[indice].PrecioU.ToString();
                txtCodigo.Text = lista[indice].Codigo.ToString();
                //dtpFechaE.Value = lista[indice].Fecha.ToString();
            }
            
        }
    }
}
