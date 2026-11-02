double dist, v1, v2, tiempo, d1, d2;

Console.Write(" distancia entre vehiculos (km): ");
dist = Convert.ToDouble(Console.ReadLine());

Console.Write(" velocidad del vehiculo 1 (km/h): ");
v1 = Convert.ToDouble(Console.ReadLine());

Console.Write(" velocidad del vehiculo 2 (km/h): ");
v2 = Convert.ToDouble(Console.ReadLine());

tiempo = dist / (v1 + v2);
d1 = v1 * tiempo;
d2 = v2 * tiempo;

Console.WriteLine();
Console.WriteLine("tiempo hasta el encuentro: " + tiempo + " h");
Console.WriteLine("distancia que recorrio el vehiculo 1: " + d1 + " km");
Console.WriteLine("distancia que recorrio el vehiculo 2: " + d2 + " km");