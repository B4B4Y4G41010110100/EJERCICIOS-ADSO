int num, u, d, c, espejo;

Console.Write(" dame un numero de tres cifras: ");
num = Convert.ToInt32(Console.ReadLine());

u = num % 10;           
d = (num / 10) % 10;    
c = num / 100;          

espejo = u * 100 + d * 10 + c;

Console.WriteLine();
Console.WriteLine("espejo: " + espejo);
