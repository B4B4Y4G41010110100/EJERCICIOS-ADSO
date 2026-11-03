Algoritmo DescuentosPorTramos
    Definir compra, porcentaje, descuento, total Como Real
	
    Escribir "Ingrese el valor de la compra:"
    Leer compra
	
    Si compra >= 200000 Entonces
        porcentaje <- 0.15
    Sino
        Si compra >= 100000 Entonces
            porcentaje <- 0.10
        Sino
            Si compra >= 50000 Entonces
                porcentaje <- 0.05
            Sino
                porcentaje <- 0
            FinSi
        FinSi
    FinSi
	
    descuento <- compra * porcentaje
    total <- compra - descuento
	
    Escribir "Descuento aplicado: $", descuento
    Escribir "Total a pagar: $", total
	
FinAlgoritmo
