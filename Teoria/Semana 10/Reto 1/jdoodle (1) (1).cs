using System;

class Program
{
    //en nuestra clase principal declaramos el codigo siguiente:
    static void Main() {
        // declaramos nuestras variables y el dato 3 lo iniciamos
        int dato2;
        int resultado = alCubo();
        int dato3 =4;
        //mandamos a imprimir el resultado y lo concatenamos con la variable que tiene almacenada nuestra respuesta
        Console.WriteLine ("El resultado es "+resultado);
        Console.WriteLine ("Otra forma de hacerlo");
        
        
        //mandamos a imprimir el resultado y lo concatenamos con la variable que tiene almacenada nuestra respuesta
        resultado = Cubo2(4);
        Console.WriteLine ("El resultado es "+resultado);
        
        
        //Luego le pedimos al usuario que ingrese un numero y el dato2 lo convertimos a un numero que pueda leer la computadora
        Console.WriteLine("Ingrese el numero");
        dato2 = Int32.Parse (Console.ReadLine());
        //mandamos a llamar a nuestro metodo denominado Cubo 2
        resultado = Cubo2(dato2);
        ////mandamos a imprimir el resultado y lo concatenamos con la variable que tiene almacenada nuestra respuesta
        Console.WriteLine("La elevacion del numero es"+resultado);
        resultado = Cubo2(dato3);
        Console.WriteLine("La elevacion del numero es"+resultado);

    }
    //creamos un metodo publico para que desde cualquier parte del codigo podamos acceder al mismo
    public static int alCubo ()
    {
        //declaramos nuestras variables
        int numero; 
        int resultado; 
        //le volvemos a indicar al usuario que ingrese un numero y este mismo lo convertimos a uno que la computadora pueda leer
        Console.WriteLine ("Ingrese el numero que desee elevar");
        numero = Int32.Parse(Console.ReadLine());
        //realizamos la operacion matem[atica
        resultado = numero * numero * numero;
        //retornamos nuestro metodo para que nos devuelva el valor
        return resultado;
    }
    
    //evaluamos nuestro numero y creamos un public en donde en el parentesis declaramos de una vez nuestra variable
    //tipo int para indicar que son numeros enteros
    public static int Cubo2 (int numero)
    {
        //declaramos nuestra variable en la que se van a almacenar los datos o la respuesta
        int resultado;
        //creamos la operacion matematica
        resultado = numero * numero * numero;
        //retornamos nuestros dato para poder obtener los valores
        return resultado; 
    }

}