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
        ValidacionHLBV v = new ValidacionHLBV();
        public FrmAlmacenHLBV()
        {
            InitializeComponent();
            dtpFechaE.Enabled = false;
            dtpFechaV.Enabled = false;
            txtCodigo.Enabled = false;
            txtPrecioU.Enabled = false;
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
        }

        void HabilitarCampos()
        {
            dtpFechaE.Enabled = true;
            dtpFechaV.Enabled = true;
            txtCodigo.Enabled = true;
            txtPrecioU.Enabled = true;
            txtNombre.Enabled = true;
            txtCantidad.Enabled = true;
        }

        void BloquearCampos()
        {
            dtpFechaE.Enabled = false;
            dtpFechaV.Enabled = false;
            //txtCodigo.Enabled = false;
            txtPrecioU.Enabled = false;
        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccion.SelectedIndex == 0)
            {
                HabilitarCampos();
            }
            else
            {
                BloquearCampos();
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
            if (char.IsLetter(c) && c != '.' && (e.KeyChar != Convert.ToChar(Keys.Back)))
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
            int iCodigo = v.AEntero(codigo);
            DateTime fechaE = dtpFechaE.Value.Date, fechaV = dtpFechaV.Value.Date, fecha = DateTime.Now;
            if (admPnp.EsCorrecto(nombre, precioU, codigo, fechaE, fechaV, cantidad))
            {
                if (accion.Equals("Compra"))
                {
                    if (admPnp.ProductoExiste(iCodigo)){
                        BloquearCampos();
                        admPnp.LlenarCampos(nombre, iCodigo, txtPrecioU, txtCodigo, dtpFechaE, dtpFechaV);
                        admPnp.Guardar(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad, accion);
                        admPnp.Mostrar(iCodigo, txtContenido);
                    }
                    else if(admPnp.ListaVacia() || admPnp.NumeroRepetido(iCodigo) == false)
                    {
                        admPnp.Guardar(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad, accion);
                        admPnp.Mostrar(iCodigo, txtContenido);
                    }
                }else if (accion.Equals("Venta"))
                {
                    if (admPnp.ProductoExiste(iCodigo))
                    {
                        admPnp.LlenarCampos(nombre, iCodigo, txtPrecioU, txtCodigo, dtpFechaE, dtpFechaV);
                        admPnp.Guardar(nombre, precioU, fecha, codigo, fechaE, fechaV, cantidad, accion);
                        admPnp.Mostrar(iCodigo,txtContenido);
                    }
                    else
                    {
                        MessageBox.Show("Error: No existe ese producto");
                    }
                }
                
            }
        }

        private void btnTiempoCaducidad_Click(object sender, EventArgs e)
        {
            txtTiempoCaducidad.Text = "";
            lblCambiar.Text = "PRODUCTO POR TIEMPO DE CADUCIDAD";
            admPnp.MostrarTiempo(txtTiempoCaducidad);
        }
            
        private void btnMasCaro_Click(object sender, EventArgs e)
        {
            txtTiempoCaducidad.Text = "";
            lblCambiar.Text = "PRODUCTO MÁS CARO";
            admPnp.MostrarMasCaro(txtTiempoCaducidad);
        }
    }
}
