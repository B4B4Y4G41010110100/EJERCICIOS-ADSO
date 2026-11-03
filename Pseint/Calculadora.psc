Algoritmo Calculadora
    Definir numero1, numero2, resultado Como Real
    Definir operador Como Caracter
	
    Escribir "Ingrese el primer número:"
    Leer numero1
    Escribir "Ingrese el segundo número:"
    Leer numero2
    Escribir "Ingrese el operador (+, -, *, /):"
    Leer operador
	
    Segun operador Hacer
        "+":
            resultado <- numero1 + numero2
            Escribir "Resultado: ", resultado
        "-":
            resultado <- numero1 - numero2
            Escribir "Resultado: ", resultado
        "*":
            resultado <- numero1 * numero2
            Escribir "Resultado: ", resultado
        "/":
            Si numero2 = 0 Entonces
                Escribir "Error: no se puede dividir entre cero."
            Sino
                resultado <- numero1 / numero2
                Escribir "Resultado: ", resultado
            FinSi
        De Otro Modo:
            Escribir "Operador inválido."
    FinSegun
	
FinAlgoritmo
