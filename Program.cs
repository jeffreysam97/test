//Leer un número entero y determinar si es un número terminado en 4.
Console.WriteLine("Inserte un numero entero...: ");
// para terminar en 4 un numero, su ultimo digito tiene que ser 4
int num = Convert.ToInt32(Console.ReadLine());
if (num%10 == 4)
{
    Console.Write("El numero insertado termina en cuatro"); 
    
}
else
{
    Console.WriteLine("El numero no termina en 4"); }
}