int num, d1, d2, d3, suma;

Console.Write(" dame un numero de tres cifras: ");
num = Convert.ToInt32(Console.ReadLine());

d1 = num / 100;          
d2 = (num / 10) % 10;    
d3 = num % 10;           

suma = d1 + d2 + d3;

Console.WriteLine();
Console.WriteLine("suma de los digitos: " + suma);
