double compra, descuento, total;

Console.Write("Ingresa el valor de la compra: ");
compra = Convert.ToDouble(Console.ReadLine());

if (compra >= 200000)
{
    descuento = compra * 0.15;
}
else if (compra >= 100000)
{
    descuento = compra * 0.10;
}
else if (compra >= 50000)
{
    descuento = compra * 0.05;
}
else
{
    descuento = 0;
}

total = compra - descuento;

Console.WriteLine("Descuento aplicado: $" + descuento);
Console.WriteLine("Total a pagar: $" + total);