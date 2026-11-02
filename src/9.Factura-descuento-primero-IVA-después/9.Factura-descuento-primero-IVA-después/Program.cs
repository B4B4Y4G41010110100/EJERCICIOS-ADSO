double sub, desc, iva, total;

Console.Write(" subtotal: ");
sub = Convert.ToDouble(Console.ReadLine());

desc = sub * 0.10; 
iva = (sub - desc) * 0.19;   
total = sub - desc + iva;

Console.WriteLine();
Console.WriteLine("descuento: " + desc);
Console.WriteLine("iva: " + iva);
Console.WriteLine("total: " + total);
