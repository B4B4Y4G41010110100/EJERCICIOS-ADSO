Algoritmo AprobacionYCausa
    Definir nota Como Real
    Definir inasistencias Como Entero
    Definir aprobado Como Logico
	
    Escribir "Ingrese la nota:"
    Leer nota
    Escribir "Ingrese la cantidad de inasistencias:"
    Leer inasistencias
	
    aprobado <- nota >= 4.0 Y inasistencias <= 3
	
    Si aprobado Entonces
        Escribir "Aprobó el curso."
    Sino
        Escribir "No aprobó el curso."
		
        Si nota < 4.0 Entonces
            Escribir "Causa: la nota es menor que 4.0."
        FinSi
		
        Si inasistencias > 3 Entonces
            Escribir "Causa: tiene más de 3 inasistencias."
        FinSi
    FinSi
	
FinAlgoritmo
