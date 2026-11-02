double angulo;

Console.Write("Ingresa el angulo en grados: ");
angulo = Convert.ToDouble(Console.ReadLine());

if (angulo < 0 || angulo > 180)
{
    Console.WriteLine("Angulo invalido.");
}
else if (angulo == 90)
{
    Console.WriteLine("Es un angulo recto.");
}
else if (angulo < 90)
{
    Console.WriteLine("Es un angulo agudo.");
}
else
{
    Console.WriteLine("Es un angulo obtuso.");
}