double vel, tiempo, dist, rend, precio, galones, costo;

Console.Write(" velocidad en km/h: ");
vel = Convert.ToDouble(Console.ReadLine());

Console.Write(" tiempo en horas: ");
tiempo = Convert.ToDouble(Console.ReadLine());

dist = vel * tiempo;

Console.Write(" rendimiento km por galon: ");
rend = Convert.ToDouble(Console.ReadLine());

Console.Write(" precio del galon: ");
precio = Convert.ToDouble(Console.ReadLine());

galones = dist / rend;
costo = galones * precio;

Console.WriteLine();
Console.WriteLine("distancia: " + dist + " km");
Console.WriteLine("galones: " + galones);
Console.WriteLine("costo: " + costo);

        Console.WriteLine();
Console.WriteLine("distancia: " + dist);
Console.WriteLine("galones necesarios: " + galones);
Console.WriteLine("costo del combustible: " + costo);
