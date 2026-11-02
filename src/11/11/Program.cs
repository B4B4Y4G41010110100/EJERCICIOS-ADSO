double lado1, lado2, lado3;
string tipo;

Console.Write("Ingresa el primer lado: ");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo lado: ");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el tercer lado: ");
lado3 = Convert.ToDouble(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    tipo = "Equilatero";
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    tipo = "Isosceles";
}
else
{
    tipo = "Escaleno";
}

Console.WriteLine("El triangulo es " + tipo);