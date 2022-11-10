using System;
class Program
{
 public static double calcularPrecio(string tipoHelado, int topping){
 double precio = 0;
 if (tipoHelado == "chicle" || tipoHelado == "ron con pasas" || tipoHelado == "vainilla"){
 precio = 5;
 }else if (tipoHelado == "oreo" || tipoHelado == "pistacho"){
 precio = 7;
 }
 switch (topping) {
 case 1: // chocolate
 precio = precio +1;
 break;
 case 2: // agragar mania
 precio = precio +2;
 break;
 case 3: // agregar anicillo
 
 precio = precio +1;
 break;
 }
 return precio;
 }
 static void Main() {
string helado;
int topping;
Console.WriteLine("Ingrese el sabor  ");
helado = Console.ReadLine();
Console.WriteLine("Toppings:\n 1.Chocolate\n2.Chocolate con mania\n3.Chocolate con anicillo\nIngrese el tipo de topping: ");
topping = Convert.ToInt32(Console.ReadLine());
 
 double precio=calcularPrecio(helado, topping);
            Console.WriteLine("El precio final es "+precio);
 }
}
