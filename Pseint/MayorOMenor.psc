Algoritmo MayorOMenor
    Definir edad, diferencia Como Entero
	
    Escribir "Ingrese la edad:"
    Leer edad
	
    Si edad >= 18 Entonces
        diferencia <- edad - 18
        Escribir "Cumplió la mayoría de edad hace ", diferencia, " años."
    Sino
        diferencia <- 18 - edad
        Escribir "Le faltan ", diferencia, " años para cumplir la mayoría de edad."
    FinSi
	
FinAlgoritmo
