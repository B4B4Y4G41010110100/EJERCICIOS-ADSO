int num, dec, uni;

Console.Write("Ingresa un numero de dos cifras: ");
num = Convert.ToInt32(Console.ReadLine());

dec = num / 10;
uni = num % 10;

if (dec == uni)
{
    Console.WriteLine(num + " es capicua.");
}
else
{
    Console.WriteLine(num + " no es capicua.");
}