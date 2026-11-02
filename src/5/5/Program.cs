int num;

Console.Write("Ingresa un numero entero: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("El numero es positivo.");
}
else if (num < 0)
{
    Console.WriteLine("El numero es negativo.");
}
else
{
    Console.WriteLine("El numero es cero.");
}