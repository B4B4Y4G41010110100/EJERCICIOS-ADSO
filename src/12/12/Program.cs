double nota;
int faltas;

Console.Write("Ingresa la nota: ");
nota = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa la cantidad de inasistencias: ");
faltas = Convert.ToInt32(Console.ReadLine());

if (nota >= 4.0 && faltas <= 3)
{
    Console.WriteLine("Aprobo el curso.");
}
else
{
    Console.WriteLine("No aprobo el curso.");

    if (nota < 4.0)
    {
        Console.WriteLine("La causa es la nota.");
    }

    if (faltas > 3)
    {
        Console.WriteLine("La causa son las inasistencias.");
    }
}