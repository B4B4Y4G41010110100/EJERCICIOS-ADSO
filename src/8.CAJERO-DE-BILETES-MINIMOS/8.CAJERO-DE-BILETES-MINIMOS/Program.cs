int monto, billete50000, billete20000, billete10000, billete5000, resto;

Console.Write("Ingresa el monto (multiplo de 5000): ");
monto = Convert.ToInt32(Console.ReadLine());

// voy sacando billetes del de mayor valor al menor
billete50000 = monto / 50000;
resto = monto % 50000;

billete20000 = resto / 20000;
resto = resto % 20000;

billete10000 = resto / 10000;
resto = resto % 10000;

billete5000 = resto / 5000;
resto = resto % 5000;

Console.WriteLine();
Console.WriteLine(" Entrega del cajero ");
Console.WriteLine("Billetes de 50000: " + billete50000);
Console.WriteLine("Billetes de 20000: " + billete20000);
Console.WriteLine("Billetes de 10000: " + billete10000);
Console.WriteLine("Billetes de 5000:  " + billete5000);
Console.WriteLine("Resto:             " + resto);
