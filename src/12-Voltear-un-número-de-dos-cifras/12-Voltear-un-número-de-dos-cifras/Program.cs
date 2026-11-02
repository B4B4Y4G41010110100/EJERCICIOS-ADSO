int num, u, d, inv;

Console.Write(" dame un numero de dos cifras: ");
num = Convert.ToInt32(Console.ReadLine());

u = num % 10;      
d = num / 10;      
inv = u * 10 + d;

Console.WriteLine();
Console.WriteLine("invertido: " + inv);
