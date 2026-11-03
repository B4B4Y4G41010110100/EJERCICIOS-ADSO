Algoritmo MayorDeTres
    Definir numero1, numero2, numero3, mayor Como Entero
	
    Escribir "Ingrese el primer número:"
    Leer numero1
    Escribir "Ingrese el segundo número:"
    Leer numero2
    Escribir "Ingrese el tercer número:"
    Leer numero3
	
    Si numero1 >= numero2 Entonces
        Si numero1 >= numero3 Entonces
            mayor <- numero1
        Sino
            mayor <- numero3
        FinSi
    Sino
        Si numero2 >= numero3 Entonces
            mayor <- numero2
        Sino
            mayor <- numero3
        FinSi
    FinSi
	
    Escribir "El mayor de los tres números es: ", mayor
	
FinAlgoritmo
