Algoritmo SaludoPorHora
    Definir hora Como Entero
	
    Escribir "Ingrese la hora en formato de 24 horas:"
    Leer hora
	
    Si hora < 0 O hora > 23 Entonces
        Escribir "Hora inválida."
    Sino
        Si hora <= 5 Entonces
            Escribir "Buenas noches, madrugada."
        Sino
            Si hora <= 12 Entonces
                Escribir "Buenos días."
            Sino
                Si hora <= 18 Entonces
                    Escribir "Buenas tardes."
                Sino
                    Escribir "Buenas noches."
                FinSi
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
