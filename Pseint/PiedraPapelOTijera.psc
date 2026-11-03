Algoritmo  PiedraPapelOTijera
    Definir jugador1, jugador2 Como Entero
	
    Escribir "Jugador 1: ingrese 1 para piedra, 2 para papel o 3 para tijera:"
    Leer jugador1
    Escribir "Jugador 2: ingrese 1 para piedra, 2 para papel o 3 para tijera:"
    Leer jugador2
	
    Si (jugador1 < 1 O jugador1 > 3) O (jugador2 < 1 O jugador2 > 3) Entonces
        Escribir "Jugada inválida."
    Sino
        Si jugador1 = jugador2 Entonces
            Escribir "Empate."
        Sino
            Si (jugador1 = 1 Y jugador2 = 3) O (jugador1 = 2 Y jugador2 = 1) O (jugador1 = 3 Y jugador2 = 2) Entonces
                Escribir "Gana el jugador 1."
            Sino
                Escribir "Gana el jugador 2."
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
