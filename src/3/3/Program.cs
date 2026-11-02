int num1, num2;

Console.Write("Ingresa el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El mayor es " + num1);
}
else if (num2 > num1)
{
    Console.WriteLine("El mayor es " + num2);
}
else
{
    Console.WriteLine("Los dos numeros son iguales.");
}