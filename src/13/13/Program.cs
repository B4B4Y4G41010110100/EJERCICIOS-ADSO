int hora;

Console.Write("Ingresa la hora entre 0 y 23: ");
hora = Convert.ToInt32(Console.ReadLine());

if (hora < 0 || hora > 23)
{
    Console.WriteLine("Hora invalida.");
}
else if (hora <= 5)
{
    Console.WriteLine("Buenas noches, madrugada.");
}
else if (hora <= 12)
{
    Console.WriteLine("Buenos dias.");
}
else if (hora <= 18)
{
    Console.WriteLine("Buenas tardes.");
}
else
{
    Console.WriteLine("Buenas noches.");