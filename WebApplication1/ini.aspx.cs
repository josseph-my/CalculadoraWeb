using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ini : System.Web.UI.Page
    {
        float n1 = 0;
        float n2 = 0;
        float total = 0;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Bresult_Click(object sender, EventArgs e)
        {
            

            string operacion = List1.SelectedValue;

            switch (operacion)
            {
                case "Sumar":
                case "Restar":
                case "Multiplicar":
                case "Dividir":
                    if (!float.TryParse(Tnum1.Text, out n1) || !float.TryParse(Tnum2.Text, out n2))
                    {
                        result.Text = "Error: Debe ingresar dos números válidos.";
                        return;
                    }
                    break;

                case "Potencia 2":
                case "Potencia 3":
                case "Raiz cuadrada":
                case "Factorial":
                case "Fibonacci":

                    if (!float.TryParse(Tnum1.Text, out n1))
                    {
                        result.Text = "Error: Debe ingresar al menos un número válido.";
                        return;
                    }
                    break;

            }

            switch (operacion)
            {
                case "Sumar":
                    total = n1 + n2;
                    break;

                case "Restar":
                    total = n1 - n2;
                    break;

                case "Multiplicar":
                    total = n1 * n2;
                    break;

                case "Dividir":
                    if (n2 != 0)
                        total = n1 / n2;
                    else
                    {
                        result.Text = "Error no se puede dividir por cero";
                        return;
                    }
                    break;

                case "Potencia 2":
                    total = n1 * n1;
                    break;

                case "Raiz cuadrada":
                    if (n1 >= 0)
                        total = (float)Math.Sqrt(n1);
                    else
                    {
                        result.Text = "Error no se puede raíz de negativo";
                        return;
                    }
                    break;

                case "Factorial":
                    if (n1 < 0 || n1 != (int)n1)
                    {
                        result.Text = "Error no ingresar negativos";
                        return;
                    }
                    total = Factorial((int)n1);
                    break;

                case "Fibonacci":
                    
                    if (n1 < 0 )
                    {
                        result.Text = "Error no ingresar negativos";
                        return;
                    }
                    total = Fibonacci((int)n1);
                    break;

                case "Potencia 3":
                    total = n1 * n1 * n1;
                    break;
            }

            result.Text = "Resultado: " + total.ToString();
            pp.Text = n1.ToString();

        }

        private int Factorial(int num)
        {
            int resultado = 1;
            for (int i = 2; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;
            int resultado = 0;

            for (int i = 2; i >= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }

            return resultado;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}