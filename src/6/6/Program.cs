double nota;
string categoria;

Console.Write("Ingresa la nota definitiva: ");
nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 4.5)
{
    categoria = "Desempeño alto";
}
else if (nota >= 4.0)
{
    categoria = "Aprobado";
}
else
{
    categoria = "No aprobado";
}

Console.WriteLine("Categoria: " + categoria);
