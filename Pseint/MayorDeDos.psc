Algoritmo MayorDeDos
    Definir numero1, numero2 Como Entero
	
    Escribir "Ingrese el primer número:"
    Leer numero1
    Escribir "Ingrese el segundo número:"
    Leer numero2
	
    Si numero1 > numero2 Entonces
        Escribir "El mayor es ", numero1
    Sino
        Si numero2 > numero1 Entonces
            Escribir "El mayor es ", numero2
        Sino
            Escribir "Los dos números son iguales."
        FinSi
    FinSi
	
FinAlgoritmo
