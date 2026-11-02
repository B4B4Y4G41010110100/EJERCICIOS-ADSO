int edad, precio;

Console.Write("Ingresa la edad: ");
edad = Convert.ToInt32(Console.ReadLine());

if (edad <= 12)
{
    precio = 8000;
}
else if (edad <= 59)
{
    precio = 12000;
}
else
{
    precio = 9000;
}

Console.WriteLine("El precio de la boleta es: $" + precio);