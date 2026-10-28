double N1, N2, N3, PG;
Console.Write("INGRESE LA NOTA 1: ");
N1 = Convert.ToInt16(Console.ReadLine());
Console.Write("INGRESE LA NOTA 2: ");
N2 = Convert.ToInt16(Console.ReadLine());
Console.Write("INGRESE LA NOTA 3: ");
N3 = Convert.ToInt16(Console.ReadLine());
PG = (N1 * 0.25)+(N2 * 0.35)+(N3 * 0.40);
Console.WriteLine($"EL PROMEDIO ES: {PG}");