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

            if (operacion == "Potencia 2" || operacion == "Potencia 3" ||
        operacion == "Raiz cuadrada" || operacion == "Factorial" || operacion == "Fibonacci")
            {
                if (!float.TryParse(Tnum1.Text, out n1))
                {
                    result.Text = "Error: Ingrese un número válido en el primer campo.";
                    return;
                }
            }

            if (operacion == "Sumar" || operacion == "Restar" ||
                operacion == "Multiplicar" || operacion == "Dividir")
            {
                if (!float.TryParse(Tnum1.Text, out n1) || !float.TryParse(Tnum2.Text, out n2))
                {
                    result.Text = "Error: Ingrese dos números válidos.";
                    return;
                }
            }
            pp.Text = n1.ToString();
            switch (operacion)
            {
                case "Sumar":
                    total = Operaciones.Sumar(n1, n2);
                    break;

                case "Restar":
                    total = Operaciones.Restar(n1, n2);
                    break;

                case "Multiplicar":
                    total = Operaciones.Multiplicar(n1, n2);
                    break;

                case "Dividir":
                    total = Operaciones.Dividir(n1, n2);
                    break;

                case "Potencia 2":
                    total = Operaciones.Potencia2(n1);
                    break;

                case "Raiz cuadrada":
                    total = Operaciones.RaizCuadrada(n1);
                    break;

                case "Factorial":
                    total = Operaciones.Factorial(n1);
                    break;

                case "Fibonacci":
                    
                    total = Operaciones.Fibonacci((int)n1);
                    break;

                case "Potencia 3":
                    total = n1 * n1 * n1;
                    break;
            }

            result.Text = "Resultado: " + total.ToString();
            

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

            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            pp.Text = n1.ToString();
            return resultado;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}