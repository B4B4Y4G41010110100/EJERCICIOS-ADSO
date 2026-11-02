int num1, num2, num3, mayor;

Console.Write("Ingresa el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el tercer numero: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        mayor = num1;
    }
    else
    {
        mayor = num3;
    }
}
else
{
    if (num2 > num3)
    {
        mayor = num2;
    }
    else
    {
        mayor = num3;
    }
}

Console.WriteLine("El mayor es " + mayor);
    