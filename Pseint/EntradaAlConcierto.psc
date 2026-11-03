Algoritmo EntradaAlConcierto
    Definir edad Como Entero
    Definir tieneBoleta Como Caracter
	
    Escribir "Ingrese la edad:"
    Leer edad
    Escribir "¿Tiene boleta? Responda S o N:"
    Leer tieneBoleta
	
    Si edad > 18 Y tieneBoleta = "S" Entonces
        Escribir "Puede entrar."
    Sino
        Escribir "No puede entrar."
		
        Si edad <= 18 Entonces
            Escribir "Condición fallida: debe ser mayor de 18 años."
        FinSi
		
        Si tieneBoleta <> "S" Entonces
            Escribir "Condición fallida: necesita tener boleta."
        FinSi
    FinSi
	
FinAlgoritmo
