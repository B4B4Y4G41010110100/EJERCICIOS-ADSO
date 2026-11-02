int num, mil, cen, dec, uni;

Console.Write(" dame un numero de cuatro cifras: ");
num = Convert.ToInt32(Console.ReadLine());

mil = num / 1000;          
cen = (num / 100) % 10;    
dec = (num / 10) % 10;     
uni = num % 10;            

Console.WriteLine();
Console.WriteLine("millares: " + mil);
Console.WriteLine("centenas: " + cen);
Console.WriteLine("decenas: " + dec);
Console.WriteLine("unidades: " + uni);
