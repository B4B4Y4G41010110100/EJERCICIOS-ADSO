int edad, diferencia;

Console.Write("Ingresa la edad: ");
edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
{
    diferencia = edad - 18;
    Console.WriteLine("Cumplio la mayoria de edad hace " + diferencia + " años.");
}
else
{
    diferencia = 18 - edad;
    Console.WriteLine("Le faltan " + diferencia + " años para cumplir la mayoria de edad.");
}