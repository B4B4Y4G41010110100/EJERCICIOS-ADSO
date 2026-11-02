int edad;
string boleta;

Console.Write("Ingresa la edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("¿Tiene boleta? (S/N): ");
boleta = Console.ReadLine().ToUpper();

if (edad > 18 && boleta == "S")
{
    Console.WriteLine("Puede entrar.");
}
else
{
    if (edad <= 18)
    {
        Console.WriteLine("No cumple con la edad requerida.");
    }

    if (boleta != "S")
    {
        Console.WriteLine("No tiene boleta.");
    }
}