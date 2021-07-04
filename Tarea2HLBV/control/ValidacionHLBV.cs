using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea2HLBV.model;

namespace Tarea2HLBV.control
{

    class ValidacionHLBV
    {
        internal bool EsReal(string valor)
        {
            bool flag = true;
            double x = 0.0;
            try
            {
                x = Convert.ToDouble(valor);
                flag = true;
            }catch(Exception e)
            {
                flag = false;
                Console.WriteLine(e.Message);
                MessageBox.Show("Error se esperaba un número real");
            }
            return flag;
        }

        internal bool EsEntero(string valor)
        {
            bool flag = true;
            int x = 0;
            try
            {
                x = Convert.ToInt32(valor);
                flag = true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
                flag = false;
            }
            return flag;
        }

        internal int AEntero(string valor)
        {
            int x = 0;
            try
            {
                x = Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
            }
            return x;
        }

        internal double AReal(string valor)
        {
            double x = 0.0;
            try
            {
                x = Convert.ToDouble(valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número real");
            }
            return x;
        }

        internal bool FechaVigente(DateTime fechaV)
        {
            DateTime fecha = DateTime.Now;
            bool flag = true;
            try
            {
                if (fechaV > fecha)
                    flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: La fecha de vencimiento no es válida");
                flag = false;
            }
            return flag;
        }
    }
}
