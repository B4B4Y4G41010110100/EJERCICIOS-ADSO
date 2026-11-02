double capitalInicial, tasaMensual, capitalFinal, interesesGanados;
int meses;

Console.Write("Ingrese el capital inicial (C): ");
capitalInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tasa de interés mensual en porcentaje (%): ");
tasaMensual = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el número de meses: ");
meses = Convert.ToInt32(Console.ReadLine());

capitalFinal = capitalInicial * Math.Pow(1 + (tasaMensual / 100), meses);

interesesGanados = capitalFinal - capitalInicial;

Console.WriteLine("\n--------------------------------------------");
Console.WriteLine($"Capital Final: ${capitalFinal:F2}");
Console.WriteLine($"Intereses Ganados: ${interesesGanados:F2}");
Console.WriteLine("--------------------------------------------");

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();