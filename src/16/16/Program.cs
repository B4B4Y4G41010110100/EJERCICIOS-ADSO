int opcion, cantidad, precio, total;

Console.WriteLine("1. Empanada - $2500");
Console.WriteLine("2. Cafe - $1800");
Console.WriteLine("3. Arepa - $3000");
Console.Write("Elige una opcion: ");
opcion = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa la cantidad: ");
cantidad = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        precio = 2500;
        total = precio * cantidad;
        Console.WriteLine("Total a pagar: $" + total);
        break;

    case 2:
        precio = 1800;
        total = precio * cantidad;
        Console.WriteLine("Total a pagar: $" + total);
        break;

    case 3:
        precio = 3000;
        total = precio * cantidad;
        Console.WriteLine("Total a pagar: $" + total);
        break;

    default:
        Console.WriteLine("Opcion invalida. No se cobra.");
        break;
}