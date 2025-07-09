using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Operaciones
    {



        public static float Sumar(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Restar(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiplicar(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Dividir(float n1, float n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return n1 / n2;
        }

        public static float Potencia2(float n1)
        {
            return n1 * n1;
        }

        public static float Potencia3(float n1)
        {
            return n1 * n1 * n1;
        }

        public static float RaizCuadrada(float n1)
        {
            if (n1 < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return (float)Math.Sqrt(n1);
        }

        public static float Factorial(float n1)
        {
            if (n1 < 0)
            {
                throw new ArgumentException("No se puede calcular el factorial de un número negativo.");
            }
            if (n1 == 0 || n1 == 1)
            {
                return 1;
            }
            float resultado = 1;
            for (int i = 2; i <= n1; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static float Fibonacci(float n1)
        {
            if (n1 == 0) return 0;
            if (n1 == 1) return 1;

            int a = 0;
            int b = 1;
            int resultado = 0;

            for (int i = 2; i <= n1; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
           
            return resultado;
        }

    }
}