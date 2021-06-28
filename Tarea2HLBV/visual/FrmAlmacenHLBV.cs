using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea2HLBV.control;

namespace Tarea2HLBV
{
    public partial class FrmAlmacenHLBV : Form
    {
        AdmProductoNoPerecibleHLBV admPnp = new AdmProductoNoPerecibleHLBV();
        public FrmAlmacenHLBV()
        {
            InitializeComponent();
        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccion.SelectedIndex == 0)
            {
                dtpFechaE.Enabled = true;
                dtpFechaV.Enabled = true;
                txtCodigo.Enabled = true;
                txtPrecioU.Enabled = true;
            }
            else
            {
                admPnp.Limpiar(txtNombre, txtPrecioU, txtCantidad, txtCodigo);
                dtpFechaE.Enabled = false;
                dtpFechaV.Enabled = false;
                txtCodigo.Enabled = false;
                txtPrecioU.Enabled = false;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ',' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim(), precioU = txtPrecioU.Text, accion = cmbAccion.Text,
                cantidad = txtCantidad.Text, codigo = txtCodigo.Text;
            DateTime fechaE = dtpFechaE.Value.Date, fechaV = dtpFechaV.Value.Date, fecha = DateTime.Now;
            if (admPnp.EsCorrecto(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad))
            {
                if (accion.Equals("Compra"))
                {
                    admPnp.guardar(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad, accion);
                    admPnp.agregar(txtContenido);

                }else if (accion.Equals("Venta"))
                {
                    if (admPnp.ProductoExiste(nombre))
                    {
                        admPnp.guardar(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad, accion);
                        admPnp.agregar(txtContenido);
                    }
                    else
                    {
                        MessageBox.Show("Error: No existe ese producto");
                    }
                }
                
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
