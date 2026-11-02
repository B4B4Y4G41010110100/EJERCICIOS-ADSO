double costo, precio, unidades, ganancia, rent;

Console.Write(" costo de fabricacion: ");
costo = Convert.ToDouble(Console.ReadLine());

Console.Write(" precio de venta: ");
precio = Convert.ToDouble(Console.ReadLine());

Console.Write(" unidades vendidas: ");
unidades = Convert.ToDouble(Console.ReadLine());

ganancia = (precio - costo) * unidades;
rent = (ganancia / (costo * unidades)) * 100;

Console.WriteLine();
Console.WriteLine("ganancia total: " + ganancia);
Console.WriteLine("rentabilidad: " + rent + " %");