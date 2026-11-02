double num1, num2, resultado;
char operador;

Console.Write("Ingresa el primer numero: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el operador (+, -, *, /): ");
operador = Convert.ToChar(Console.ReadLine());

Console.Write("Ingresa el segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        Console.WriteLine("Resultado: " + resultado);
        break;

    case '-':
        resultado = num1 - num2;
        Console.WriteLine("Resultado: " + resultado);
        break;

    case '*':
        resultado = num1 * num2;
        Console.WriteLine("Resultado: " + resultado);
        break;

    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
        }
        else
        {
            resultado = num1 / num2;
            Console.WriteLine("Resultado: " + resultado);
        }
        break;

    default:
        Console.WriteLine("Operador invalido.");
        break;
}