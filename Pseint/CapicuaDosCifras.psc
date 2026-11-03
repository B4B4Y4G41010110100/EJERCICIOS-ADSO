Algoritmo CapicuaDosCifras
    Definir numero, decena, unidad Como Entero
	
    Escribir "Ingrese un número entero de dos cifras:"
    Leer numero
	
    decena <- numero / 10
    unidad <- numero MOD 10
	
    Si decena = unidad Entonces
        Escribir numero, " es capicúa."
    Sino
        Escribir numero, " no es capicúa."
    FinSi
	
FinAlgoritmo
