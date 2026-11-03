int numero = int.Parse(Console.ReadLine()!);

int decenas = numero / 10;
int unidades = numero % 10;
int numeroInvertido = (unidades * 10) + decenas;

Console.WriteLine($"El número invertido es: {numeroInvertido}");
