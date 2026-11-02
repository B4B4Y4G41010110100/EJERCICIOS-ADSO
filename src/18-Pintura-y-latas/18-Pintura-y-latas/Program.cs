double m2, rend, litros, lata, latas, sueltos;

Console.Write(" metros cuadrados a pintar: ");
m2 = Convert.ToDouble(Console.ReadLine());

Console.Write(" rendimiento (m2 por litro): ");
rend = Convert.ToDouble(Console.ReadLine());

Console.Write(" litros por lata: ");
lata = Convert.ToDouble(Console.ReadLine());

litros = m2 / rend;
latas = Math.Floor(litros / lata);
sueltos = litros - (latas * lata);

Console.WriteLine();
Console.WriteLine("litros totales: " + litros);
Console.WriteLine("latas completas: " + latas);
Console.WriteLine("litros sueltos: " + sueltos);