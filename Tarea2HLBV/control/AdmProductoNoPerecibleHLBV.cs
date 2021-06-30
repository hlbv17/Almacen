using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tarea2HLBV.model;

namespace Tarea2HLBV.control
{
    class AdmProductoNoPerecibleHLBV
    {
        List<ProductoHLBV> lista = new List<ProductoHLBV>();
        ValidacionHLBV v = new ValidacionHLBV();
        ProductoHLBV p = null;
        ProductoNoPerecibleHLBV pnp = null;
        List<int> tiempoCaducidad = new List<int>();

        internal ProductoNoPerecibleHLBV MasCaro()
        {
            double n = 0.0;
            int num = 0;
            foreach (ProductoHLBV miProducto in lista)
            {
                if (miProducto.GetType() == typeof(ProductoNoPerecibleHLBV))
                {
                    pnp = (ProductoNoPerecibleHLBV)miProducto;
                    pnp.PrecioU = miProducto.PrecioU;
                    pnp.Nombre = miProducto.Nombre;
                }
                n = lista.Max(x => x.PrecioU);
                num = lista.FindIndex(x => x.PrecioU == n);
                pnp = (ProductoNoPerecibleHLBV)lista[num];
            }
            return pnp;
        }

        internal void MostrarMasCaro(TextBox txtTiempoCaducidad)
        {
            pnp = MasCaro();
            txtTiempoCaducidad.Text += "\r\n"+pnp.ToString();
        }


        internal List<int> OrdenarXCaducacion()
        {
            ProductoNoPerecibleHLBV pnp = null;
            DateTime f, fv;
            int tiempo;
            string mostrar, result = "";
            foreach (ProductoHLBV miProducto in lista)
            {
                if (miProducto.GetType() == typeof(ProductoNoPerecibleHLBV))
                {
                    pnp = (ProductoNoPerecibleHLBV)miProducto;
                    //nombre = pnp.Nombre;
                    f = pnp.Fecha;
                    fv = pnp.FechaV;
                    result = pnp.TiempoCaducidad(fv, f);
                    result = Regex.Match(result, @"\d+").Value;
                    tiempo = Int32.Parse(result);
                    mostrar = "\r\nCaduca en: "+tiempo+ " días \n" + miProducto;
                    tiempoCaducidad.Add(tiempo);
                }
            }
            tiempoCaducidad.Sort();
            return tiempoCaducidad;
        }


        internal void MostrarTiempo(TextBox txtContenido)
        {
            tiempoCaducidad = OrdenarXCaducacion();
            foreach(int tiempo in tiempoCaducidad)
            {
                foreach (ProductoHLBV miProducto in lista)
                {
                    pnp = (ProductoNoPerecibleHLBV)miProducto;
                    if (miProducto.GetType() == typeof(ProductoNoPerecibleHLBV)
                        && tiempo == (pnp.FechaV-pnp.Fecha).Days)
                    {
                        //pnp = (ProductoNoPerecibleHLBV)miProducto;
                        txtContenido.Text += "\r\nCaduca en: " + tiempo + 
                            " días \r\n " + miProducto + "\r\n";
                    }
                }
            }
        }

        internal bool EsCorrecto(string nombre, string precioU,
            string codigo, DateTime fechaE, DateTime fechaV, string cantidad)
        {
            bool x = true;
            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(precioU) && String.IsNullOrEmpty(cantidad)
                && String.IsNullOrEmpty(codigo) && fechaE != null && fechaV != null && v.EsEntero(cantidad)
                && v.EsEntero(codigo) && v.EsReal(precioU))
            {
                x = true;
            }
            return x;
        }

        internal void Limpiar(TextBox txtNombre, TextBox txtPrecioU, TextBox txtCantidad, 
            TextBox txtCodigo, DateTimePicker dtpFechaE, DateTimePicker dtpFechaV)
        {
            txtNombre.Text = "";
            txtPrecioU.Text = "";
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            dtpFechaE.Value = DateTime.Now;
            dtpFechaV.Value = DateTime.Now;
        }

        internal int Compra(int iCantidad, int indice)
        {
            int stock = lista[indice].Stock;
            stock -= iCantidad;
            return stock;
        }

        internal int Vende(int iCantidad, int indice)
        {
            int stock = lista[indice].Stock;
            if (iCantidad > stock)
            {
                MessageBox.Show("Error: No hay esa cantidad disponible en stock");
            }
            else
            {
                stock -= iCantidad;
            }
            return stock;
        }

        internal int IndexProductoExiste(int codigo)
        {
            int n = 0;
            try
            {
                n = lista.FindIndex(x => x.Codigo == codigo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: El producto no existe en stock");
            }
            return n;
        }

        internal bool ProductoExiste(int codigo)
        {
            bool flag = true;
            try
            {
                flag = lista.Any(x => x.Codigo == codigo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: El producto no existe");
                flag = false;
            }
            return flag;
        }

        internal bool ListaVacia()
        {
            bool flag = true;
            if (lista.Count == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        internal bool NumeroRepetido(int codigo)
        {
            bool flag = false;
            if (lista.Any(x => x.Codigo == codigo))
            {
                MessageBox.Show("Error: el código debe ser único");
                flag = true;
            }
            return flag;
        }

        internal void Guardar(string nombre, string precioU, DateTime fecha,
            string codigo, DateTime fechaE, DateTime fechaV, string cantidad, string accion)
        {
            //ProductoNoPerecibleHLBV pnp = null;
            int stock = 0, indice = 0, iCantidad = v.AEntero(cantidad), iCodigo = v.AEntero(codigo);
            if (accion.Equals("Compra"))
            {
                double dPrecioU = v.AReal(precioU);
                if (lista.Any(x => x.Codigo == iCodigo) && lista.Any(x => x.Nombre == nombre))
                {
                    indice = IndexProductoExiste(iCodigo);
                    stock = Compra(iCantidad, indice);
                    lista[indice].Stock = stock;
                }
                else if(ListaVacia() || NumeroRepetido(iCodigo) == false)
                {
                    stock = iCantidad;
                    pnp = new ProductoNoPerecibleHLBV(fechaE, fechaV, nombre, dPrecioU, stock, fecha, iCodigo);
                    lista.Add(pnp);
                }
            }
            else if(accion.Equals("Venta"))
            {
                if (ProductoExiste(iCodigo) && lista.Any(x => x.Nombre == nombre))
                {
                    indice = IndexProductoExiste(iCodigo);
                    stock = Vende(iCantidad, indice);
                    //ProductoNoPerecibleHLBV pnp = (ProductoNoPerecibleHLBV)p;
                    lista[indice].Stock = stock;
                }
            }
        }

        internal void Mostrar(int codigo, TextBox txtContenido)
        {
            int indice = IndexProductoExiste(codigo);
            txtContenido.Text += "\r\n" + lista[indice].ToString();
        }

        internal void LlenarCampos(string nombre, int codigo, TextBox txtPrecioU, 
            TextBox txtCodigo, DateTimePicker dtpFechaE, DateTimePicker dtpFechaV)
        {
            //ProductoHLBV p = new ProductoNoPerecibleHLBV(); //Up-casting.
            //ProductoNoPerecibleHLBV pnp = (ProductoNoPerecibleHLBV)p;  //Down-casting.
            foreach (ProductoHLBV miProducto in lista)
            {
                if (miProducto.GetType() == typeof(ProductoNoPerecibleHLBV) && ProductoExiste(codigo)
                    && lista.Any(x => x.Nombre == nombre))
                {
                    pnp = (ProductoNoPerecibleHLBV)miProducto;
                    txtPrecioU.Text = pnp.PrecioU.ToString();
                    //txtCodigo.Text = pnp.Codigo.ToString();
                    dtpFechaE.Value = pnp.FechaE;
                    dtpFechaV.Value = pnp.FechaV;   
                }
            }    
        }
    }
}
