using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                MessageBox.Show("Error: se esperaba un número entero");
            }
            return x;
        }

        internal DateTime ADate(string valor)
        {
            DateTime x = DateTime.Now;
            try
            {
                x = Convert.ToDateTime(valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
            }
            return x;
        }

        internal string ACadena(DateTime valor)
        {
            string x = "";
            try
            {
                x = Convert.ToString(valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
            }
            return x;
        }

    }
}
