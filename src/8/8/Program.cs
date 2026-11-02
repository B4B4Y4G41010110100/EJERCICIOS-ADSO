double peso, altura, imc;
string categoria;

Console.Write("Ingresa el peso en kg: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa la altura en metros: ");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine("IMC: " + imc);
Console.WriteLine("Categoria: " + categoria);