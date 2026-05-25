/*Console.WriteLine("Hello, World!");

int a = 10; 
int b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);*/

float numero = 0, numeroInvertido = 0;

Console.WriteLine("Ingrese un numero:");
string? input = Console.ReadLine();

if (float.TryParse(input, out numero))
{
    if (numero > 0)
    {
        numeroInvertido = 1 / numero;
        Console.WriteLine("El numero invertido de " + numero + " es: " + numeroInvertido);
    } 
    else
    {
        Console.WriteLine("El numero debe ser mayor a 0");   
    }
    
} 
else
{
    Console.WriteLine("No se ingreso un numero");    
}


