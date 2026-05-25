int numero1, numero2, operacion, resultado=0;

Console.WriteLine("Ingrese una operacion:");
Console.WriteLine("1- Suma");
Console.WriteLine("2- Resta");
Console.WriteLine("3- Multiplicacion");
Console.WriteLine("4- Division");
string? entrada = Console.ReadLine();
if (!int.TryParse(entrada, out operacion))
{
    Console.WriteLine("Error en la operacion elegida");
    return;
}

Console.WriteLine("Ingrese los operando:");
string? n1 = Console.ReadLine();
if (!int.TryParse(n1, out numero1))
{
    Console.WriteLine("Error en el operando 1");
    return;
}

string? n2 = Console.ReadLine();
if (!int.TryParse(n2, out numero2))
{
    Console.WriteLine("Error en el operando 2");
    return;
}

switch (operacion)
{
    case 1:
        resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;
    case 3:
        resultado = numero1 * numero2;
        break;
    case 4:
        resultado = numero1 / numero2;
        break;
}

Console.WriteLine("Resultado: " + resultado.ToString());

