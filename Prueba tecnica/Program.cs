using System;

namespace Prueba_tecnica
{
    class Program
    {
        static double IVA_VALOR = 0.19;
        
        public static double IVA(double valor)
        {
            double valorIva = (valor * IVA_VALOR);
            return valorIva;
        }

        public static double ValorT(double valor, double valorIva, double cantidad)
        {
            double valorTotal = cantidad * (valor + valorIva);
            return valorTotal;
        }

        public static void productos()
        {
            Console.WriteLine("Ingrese el valor del producto");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos");
            double cantidad = double.Parse(Console.ReadLine());
            double valorIva = IVA(valor);
            double valorTotal = ValorT(valor, valorIva, cantidad);
            Console.WriteLine("El valor del producto es: " + valor);
            Console.WriteLine("El valor del iva es: " + valorIva);
            Console.WriteLine("El valor total es: " + valorTotal);
        }

        public static void Matriz()
        {
            Console.WriteLine("Introduzca el tamaño de la matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] mat;
            mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Ingrese el valor de la posicion [" + i + "," + j + "]");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La matriz es: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "La diagonal principal es: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("\n" + "La diagonal secundaria es: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese ejercicio a revisar");
            Console.WriteLine("Ejercicio 1: Ejercicio tienda IVA y valor total correspondiente al punto 1 y 2 del documento");
            Console.WriteLine("Ejercicio 2: Ejecicio diagonales Matriz correspondiente al punto 3 del documento");

            int ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                    productos();
                    break;
                case 2:
                    Matriz();
                    break;
                default:
                    Console.WriteLine("Ejercicio no encontrado");
                    break;
            }
        }
    }
}

