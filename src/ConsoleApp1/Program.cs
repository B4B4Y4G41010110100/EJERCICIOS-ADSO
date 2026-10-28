int a, b, c;
Console.Write("introduzca el valor de a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("introduzca el valor de b: ");
b = Convert.ToInt32(Console.ReadLine());
c = a;
a = b;
b = c;
Console.WriteLine($"el valor de las variables es: A:{a} B:{b}");