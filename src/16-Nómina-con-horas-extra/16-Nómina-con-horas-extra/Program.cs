double horas, vhora, bace, extras, total;

Console.Write(" horas trabajadas: ");
horas = Convert.ToDouble(Console.ReadLine());

Console.Write(" valor de la hora: ");
vhora = Convert.ToDouble(Console.ReadLine());

bace = 160 * vhora;
extras = (horas - 160) * vhora * 1.25;
total = bace + extras;

Console.WriteLine();
Console.WriteLine("salario base: " + bace);
Console.WriteLine("pago de extras: " + extras);
Console.WriteLine("total: " + total);