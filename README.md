# Documentación Prueba Tecníca
## Ejercicio 1 Ventas.
En este punto se busca la manera de calcular las ventas teniendo en cuenta el IVA y la cantidad del producto. Para esto se crearon dos funciones en el cual se encargan de calcular el IVA del producto y el precio total, teniendo en cuenta la cantidad del producto con IVA incluido.

La primer función creada se llama IVA que recive como parametro el valor del producto, el cual se multiplica por el valor del IVA, para Colombia el IVA establecido es del 19%


```c#
static double IVA_VALOR = 0.19;

    public static double IVA(double valor)
        {
            double valorIva = (valor * IVA_VALOR);
            return valorIva;
        }
```
La segunda función creada se llama ValorT, el cual recive tres parametros difertenes, el primero es el valor del producto sin IVA, el segundo es el valor del IVA del producto y por ultimo la cantidad de articulos que se comparan.

Para calcular el valor total del producto se realizo una operación matematica en el cual el valor del producto se suma con el iva de este, para despues multiplicar con la cantidad de productos que se registraron.

```c#
 public static double ValorT(double valor, double valorIva, double cantidad)
        {
            double valorTotal = cantidad * (valor + valorIva);
            return valorTotal;
        }
```
Al ejecutar el desarrollo el usuario visualizara lo siguiente: (valores de prueba: cantidad de productos -> 3, valor del producto -> 3800)

```Plain-text
Ingrese el valor del producto
3800
Ingrese la cantidad de productos
3
El valor del producto es: 3800
El valor del iva es: 722
El valor total es: 13566
```
## Ejercicio 2 Matriz.
En este punto se busca la manera de registrar datos a una matriz n x n y mostrar al usuario los valores diagonales de esta misma.

En este ejercicio se implemento la logica en una función, cual consta de 3 partes: 

- Cargue de datos en matriz.
- Impresión de la matriz.
- Impresión diagonales de la matriz.
  
### Cargue de datos en matriz.
En este primer paso se le pedira al usuario el tamaño de la matriz, despues se le solicitara el valor de cada una de las posiciones.

Para el cargue de la información se crearon dos ciclos for en el cual se mueve horizonalmente y la segunda verticalmente par que los datos se distribuyan en toda la matriz.
```c#
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
```

### Impresión de la matriz.
En este segundo paso se le mostrara al usuario como quedo graficamente la matriz con sus datos cargados, en este caso solo se recorre la matriz para lograr imprimirlo por consola.
```c#
Console.WriteLine("La matriz es: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mat[i, j] + " ");
    }
    Console.WriteLine();
}
```
### Impresión diagonales de la matriz
Este caso se divide en dos partes, la primera diagonal se encarga de recorrer las posiciones de la matriz que son i y j, se imprime el valor si i y j son iguales.
```c#
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
```
Para la segunda diagonal de la matriz, se busca igualar la suma de las posiciones i y j de la matriz con el tamaño de la matriz menos 1.
```c#
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
```

Al ejecutar el desarrollo el usuario visualizara lo siguiente:

```Plain-text
Introduzca el tamaño de la matriz
3
Ingrese el valor de la posicion [0,0]
1
Ingrese el valor de la posicion [0,1]
2
Ingrese el valor de la posicion [0,2]
3
Ingrese el valor de la posicion [1,0]
4
Ingrese el valor de la posicion [1,1]
5
Ingrese el valor de la posicion [1,2]
6
Ingrese el valor de la posicion [2,0]
7
Ingrese el valor de la posicion [2,1]
8
Ingrese el valor de la posicion [2,2]
9
La matriz es:
1 2 3
4 5 6
7 8 9

La diagonal principal es:
1 5 9
La diagonal secundaria es:
3 5 7
```
