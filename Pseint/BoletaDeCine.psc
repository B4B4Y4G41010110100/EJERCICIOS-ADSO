Algoritmo BoletaDeCine
    Definir edad, precio Como Entero
	
    Escribir "Ingrese la edad:"
    Leer edad
	
    Si edad <= 12 Entonces
        precio <- 8000
    Sino
        Si edad <= 59 Entonces
            precio <- 12000
        Sino
            precio <- 9000
        FinSi
    FinSi
	
    Escribir "El precio de la boleta es: $", precio
	
FinAlgoritmo
