int num, resto;

Console.Write("Ingresa un numero entero: ");
num = Convert.ToInt32(Console.ReadLine());

resto = num % 2;

if (resto == 0)
{
    Console.WriteLine(num + " es par.");
}
else
{
    Console.WriteLine(num + " es impar.");
}