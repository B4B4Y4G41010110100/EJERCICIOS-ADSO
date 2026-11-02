double c1, c2, hip;

Console.Write(" cateto 1: ");
c1 = Convert.ToDouble(Console.ReadLine());

Console.Write(" cateto 2: ");
c2 = Convert.ToDouble(Console.ReadLine());

hip = Math.Sqrt(c1 * c1 + c2 * c2);  
Console.WriteLine();
Console.WriteLine("hipotenusa: " + hip);
