int jugada1, jugada2;

Console.WriteLine("1. Piedra");
Console.WriteLine("2. Papel");
Console.WriteLine("3. Tijera");

Console.Write("Jugada del jugador 1: ");
jugada1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Jugada del jugador 2: ");
jugada2 = Convert.ToInt32(Console.ReadLine());

if (jugada1 < 1 || jugada1 > 3 || jugada2 < 1 || jugada2 > 3)
{
    Console.WriteLine("Una de las jugadas no es valida.");
}
else if (jugada1 == jugada2)
{
    Console.WriteLine("Empate.");
}
else if ((jugada1 == 1 && jugada2 == 3) ||
         (jugada1 == 2 && jugada2 == 1) ||
         (jugada1 == 3 && jugada2 == 2))
{
    Console.WriteLine("Gana el jugador 1.");
}
else
{
    Console.WriteLine("Gana el jugador 2.");
}