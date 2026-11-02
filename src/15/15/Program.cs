int dia;

Console.Write("Ingresa un numero del 1 al 7: ");
dia = Convert.ToInt32(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
    case 7:
        Console.WriteLine("¡Fin de semana!");
        break;
    default:
        Console.WriteLine("Dia invalido.");
        break;
}