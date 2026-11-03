Algoritmo MenuDeCafeteria
    Definir opcion, cantidad, precio Como Entero
    Definir total Como Real
	
    Escribir "1. Empanada: $2500"
    Escribir "2. Café: $1800"
    Escribir "3. Arepa: $3000"
    Escribir "Seleccione una opción:"
    Leer opcion
	
    Escribir "Ingrese la cantidad:"
    Leer cantidad
	
    Segun opcion Hacer
        1:
            precio <- 2500
            total <- precio * cantidad
            Escribir "Total a pagar: $", total
        2:
            precio <- 1800
            total <- precio * cantidad
            Escribir "Total a pagar: $", total
        3:
            precio <- 3000
            total <- precio * cantidad
            Escribir "Total a pagar: $", total
        De Otro Modo:
            Escribir "Opción desconocida. No se realiza ningún cobro."
    FinSegun
	
FinAlgoritmo
